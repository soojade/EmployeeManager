using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Common;
using DAS;
using Models;

namespace EmployeeManager {
    public partial class FormMain : Form {
        private string fileName = "";
        private string directoryName = "./img";
        private string photoPath = "";
        private List<Employee> employeeList = null;
        private List<Employee> employeeQueryList = new List<Employee>();
        private EmployeeService employeeService = new EmployeeService();
        private int flag = 0; // 0修改 1添加

        public FormMain() {
            InitializeComponent();
        }

        // 关闭程序时确认是否保存
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show("关闭前是否保存？", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                File.WriteAllText(fileName, string.Empty); // 清空文件内容
                StreamWriter stream = new StreamWriter(fileName, true, Encoding.Default);
                string line = "";
                foreach (Employee item in employeeList) {
                    line = item.EId + ',' + item.EName + ',' + item.ESex + ',' + item.EPhone + ',' +
                        item.EBDay + ',' + item.EAddr + ',' + item.EPhotoPath;
                    stream.WriteLine(line);
                }
                stream.Close();
                MessageBox.Show("保存完成，退出！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // 按工号查询
        private void tbQueryId_TextChanged(object sender, EventArgs e) {
            if (employeeList == null) {
                MessageBox.Show("请先导入数据再查询！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                employeeQueryList.Clear(); // 清空员工列表
                tbQueryName.Text = "";

                employeeQueryList = employeeService.GetAllEmployeeById(tbQueryId.Text.ToString(), employeeList);

                if (tbQueryId.Text != "") {
                    dgvEmployeeShow.DataSource = null; // 解除datagridview数据绑定
                    dgvEmployeeShow.DataSource = employeeQueryList;

                } else {
                    dgvEmployeeShow.DataSource = employeeList;
                }

                if (employeeQueryList.Count != 0) {
                    // 将表格中第一行数据默认显示到编辑区
                    Employee employee = employeeService.GetEmployeeById(dgvEmployeeShow.Rows[0].Cells[0].Value.ToString(), employeeList);
                    LoadDataDetail(employee);
                }
            }
        }

        // 按姓名查询
        private void tbQueryName_TextChanged(object sender, EventArgs e) {
            if (employeeList == null) {
                MessageBox.Show("请先导入数据再查询！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                employeeQueryList.Clear(); // 清空员工列表
                tbQueryId.Text = "";
                employeeQueryList = employeeService.GetAllEmployeeByName(tbQueryName.Text.ToString(), employeeList);

                if (tbQueryName.Text != "") {
                    dgvEmployeeShow.DataSource = null; // 解除datagridview数据绑定
                    dgvEmployeeShow.DataSource = employeeQueryList;

                } else {
                    dgvEmployeeShow.DataSource = employeeList;
                }

                if (employeeQueryList.Count != 0) {
                    // 将表格中第一行数据默认显示到编辑区
                    Employee employee = employeeService.GetEmployeeById(dgvEmployeeShow.Rows[0].Cells[0].Value.ToString(), employeeList);
                    LoadDataDetail(employee);
                }
            }
        }

        // 提交修改
        private void btnSubmit_Click(object sender, EventArgs e) {
            if (!InputCheck()) return;

            Employee employee = new Employee {
                EId = tbEditId.Text.Trim(),
                EName = tbEditName.Text.Trim(),
                ESex = rbtnEditMan.Checked ? "男" : "女",
                EPhone = tbEditPhone.Text.Trim(),
                EBDay = Convert.ToDateTime(dtpEditBDay.Text),
                EAddr = tbEditAddr.Text.Trim(),
                EPhotoPath = null
            };

            if (pbEditPhoto.BackgroundImage != null) {
                employee.EPhotoPath = SavePhoto(photoPath);
            }

            switch (flag) {
                case 0: // 修改
                    try {
                        employeeService.UpdateEmployee(employee, employeeList);
                        tbEditId.Enabled = true;
                        btnCancel_Click(null, null); // 更新显示信息
                        MessageBox.Show("修改成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception exp) {
                        MessageBox.Show("修改失败！" + exp.Message, "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 1: // 添加
                    try {
                        employeeService.AddEmployee(employee, employeeList);
                        btnCancel_Click(null, null);

                        int index = dgvEmployeeShow.Rows.Count - 1; // 获取新添加行的索引
                        dgvEmployeeShow.Rows[index].Selected = true; // 将新添加行设置为选中状态
                        Employee employeeSelected = employeeService.GetEmployeeById(dgvEmployeeShow.Rows[index].Cells[0].Value.ToString(), employeeList);
                        LoadDataDetail(employeeSelected); // 将新添加行的信息显示到编辑区
                        MessageBox.Show("添加成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception exp) {
                        MessageBox.Show("添加失败！" + exp.Message, "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
            ToggleAble(true);
        }

        // 取消修改
        private void btnCancel_Click(object sender, EventArgs e) {
            ToggleAble(true);
            if (employeeList.Count != 0) {
                this.dgvEmployeeShow.DataSource = null;
                this.dgvEmployeeShow.DataSource = employeeList;
                Employee employee = employeeService.GetEmployeeById(dgvEmployeeShow.CurrentRow.Cells[0].Value.ToString(), employeeList);
                LoadDataDetail(employee);
            }
        }

        // 导入数据事件
        private void btnImport_Click(object sender, EventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT文件(*.txt)|*.txt|CSV文件(*.csv)|*.csv|所有文件(*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK) {
                fileName = openFile.FileName;
            }

            try {
                FileOperator fileOperator = new FileOperator();
                employeeList = fileOperator.ReadFile(fileName); // 读取文件并赋值给list
            } catch (Exception exp) {
                MessageBox.Show("导入错误：" + exp.Message, "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // 将dataGridView数据源绑定为List 并禁止生成新的列
            dgvEmployeeShow.DataSource = null;
            dgvEmployeeShow.AutoGenerateColumns = false;
            dgvEmployeeShow.DataSource = employeeList;

            // 将表格中第一行数据默认显示到编辑区
            Employee employee = employeeService.GetEmployeeById(dgvEmployeeShow.Rows[0].Cells[0].Value.ToString(), employeeList);
            LoadDataDetail(employee);

            // 清除没有导入数据时查询的文本框内容
            tbQueryId.Text = "";
            tbQueryName.Text = "";
        }

        // 添加
        private void btnAdd_Click(object sender, EventArgs e) {
            ToggleAble(false);
            EditClear();
            tbEditId.Focus();
            flag = 1;
        }

        // 修改
        private void btnUpdate_Click(object sender, EventArgs e) {
            ToggleAble(false);
            tbEditId.Enabled = false; // 工号不允许修改
            tbEditName.Focus();
            flag = 0;
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvEmployeeShow.Rows.Count == 0 || dgvEmployeeShow.CurrentRow.Selected == false) {
                return;
            } else {
                Employee employee = employeeService.GetEmployeeById(dgvEmployeeShow.CurrentRow.Cells[0].Value.ToString(), employeeList);
                DialogResult result = MessageBox.Show("您确定要删除 " + employee.EId + " 员工的信息吗？", "询问!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    try {
                        employeeService.DeleteEmployee(employee, employeeList);
                        btnCancel_Click(null, null);
                        MessageBox.Show("删除成功！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception exp) {
                        MessageBox.Show("删除失败！" + exp.Message, "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // 添加照片
        private void btnEditPhotoAdd_Click(object sender, EventArgs e) {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "图片|*.jpg;*.jpeg;*.png;*.gif";
            if (file.ShowDialog() == DialogResult.OK) {
                photoPath = file.FileName;
                pbEditPhoto.BackgroundImage = Image.FromFile(photoPath);
            }
        }

        // 编辑区显示表格选中行的信息
        private void dgvEmployeeShow_SelectionChanged(object sender, EventArgs e) {
            if (dgvEmployeeShow.Rows.Count == 0 || dgvEmployeeShow.CurrentRow.Selected == false) {
                return;
            } else {
                Employee employee = employeeService.GetEmployeeById(dgvEmployeeShow.CurrentRow.Cells[0].Value.ToString(), employeeList);
                LoadDataDetail(employee);
            }
        }

        // 加载详情信息
        private void LoadDataDetail(Employee emp) {
            tbEditId.Text = emp.EId;
            tbEditName.Text = emp.EName;
            tbEditPhone.Text = emp.EPhone;
            tbEditAddr.Text = emp.EAddr;
            dtpEditBDay.Text = emp.EBDay.ToString();
            if (emp.ESex == "男") {
                rbtnEditMan.Checked = true;
            } else {
                rbtnEditWoman.Checked = true;
            }

            if (string.IsNullOrWhiteSpace(emp.EPhotoPath)) {
                pbEditPhoto.BackgroundImage = null;
            } else {
                pbEditPhoto.BackgroundImage = Image.FromFile(emp.EPhotoPath);
            }
        }

        // 根据添加删除转换button状态
        private void ToggleAble(bool bl) {
            btnImport.Enabled = bl;
            btnAdd.Enabled = bl;
            btnUpdate.Enabled = bl;
            btnDelete.Enabled = bl;

            gbEmployeeEdit.Enabled = !bl; // 转换编辑区状态
            btnSubmit.Enabled = !bl;
            btnCancel.Enabled = !bl;
        }

        // 清空编辑区显示内容
        private void EditClear() {
            tbEditId.Text = "";
            tbEditName.Text = "";
            tbEditPhone.Text = "";
            dtpEditBDay.Text = "";
            tbEditAddr.Text = "";
            rbtnEditMan.Checked = false;
            rbtnEditWoman.Checked = false;
            pbEditPhoto.BackgroundImage = null;
        }

        // 验证输入
        private bool InputCheck() {
            bool bl = true;
            // 工号 姓名不能为空
            if (string.IsNullOrWhiteSpace(tbEditId.Text) || string.IsNullOrWhiteSpace(tbEditName.Text)) {
                MessageBox.Show("不能为空!", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEditId.Focus();
                return false;
            } else if (!InputVerification.IsId(tbEditId.Text)) {
                MessageBox.Show("请输入4位有效数字！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEditId.Focus();
                return false;
            } else if (flag != 0 && employeeService.GetAllEmployeeById(tbEditId.Text, employeeList).Count != 0) {
                MessageBox.Show("员工已存在，请重新输入！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEditId.Focus();
                return false;
            } else if (!InputVerification.IsName(tbEditName.Text)) {
                MessageBox.Show("姓名必须为中文或英文，不包含符号，请重新输入！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEditName.Focus();
                return false;
            } else if (!InputVerification.IsPhone(tbEditPhone.Text)) {
                MessageBox.Show("手机号必须为11位有效数字，请重新输入！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEditPhone.Focus();
                return false;
            } else if (Convert.ToDateTime(dtpEditBDay.Text) > DateTime.Now) {
                MessageBox.Show("日期不得晚于现在，请重新输入！", "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpEditBDay.Focus();
                return false;
            }
            return bl;
        }

        // 保存照片
        private string SavePhoto(string photo) {
            string photoName = CreateFileName.CreatePhotoName(photo);
            if (!Directory.Exists(directoryName)) {
                Directory.CreateDirectory(directoryName);
            }
            photoName = "./img/" + photoName;

            Bitmap photoBit = new Bitmap(pbEditPhoto.BackgroundImage);
            photoBit.Save(photoName, pbEditPhoto.BackgroundImage.RawFormat);
            photoBit.Dispose();
            return photoName;
        }
    }
}
