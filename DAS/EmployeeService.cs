using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Models;

namespace DAS {
    public class EmployeeService {
        /// <summary>
        /// 通过id获取一个员工信息
        /// </summary>
        /// <param name="id">工号</param>
        /// <param name="list">要查询的列表</param>
        /// <returns></returns>
        public Employee GetEmployeeById(string id,List<Employee> list) {
            Employee employee = new Employee();

            foreach (var item in list) {
                if (item.EId.Equals(id)) {
                    employee = new Employee {
                        EId = item.EId,
                        EName = item.EName,
                        ESex = item.ESex,
                        EPhone = item.EPhone,
                        EBDay = item.EBDay,
                        EAddr = item.EAddr,
                        EPhotoPath = item.EPhotoPath
                    };
                    break;
                }
            }

            return employee;
        }

        /// <summary>
        /// 根据工号获取员工信息
        /// </summary>
        /// <param name="id">工号</param>
        /// <param name="list">要查询的列表</param>
        /// <returns></returns>
        public List<Employee> GetAllEmployeeById(string id,List<Employee> list) {
            List<Employee> employees = new List<Employee>();
            foreach (var item in list) {
                if (item.EId.StartsWith(id)) {
                    employees.Add(new Employee {
                        EId = item.EId,
                        EName = item.EName,
                        ESex = item.ESex,
                        EPhone = item.EPhone,
                        EBDay = item.EBDay,
                        EAddr = item.EAddr,
                        EPhotoPath = item.EPhotoPath
                    });
                }
            }
            return employees;
        }

        /// <summary>
        /// 根据姓名查询员工信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="list">要查询的列表</param>
        /// <returns></returns>
        public List<Employee> GetAllEmployeeByName(string name, List<Employee> list) {
            List<Employee> employees = new List<Employee>();
            foreach (var item in list) {
                if (item.EName.StartsWith(name)) {
                    employees.Add(new Employee {
                        EId = item.EId,
                        EName = item.EName,
                        ESex = item.ESex,
                        EPhone = item.EPhone,
                        EBDay = item.EBDay,
                        EAddr = item.EAddr,
                        EPhotoPath = item.EPhotoPath
                    });
                }
            }
            return employees;
        }

        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="list"></param>
        public void AddEmployee(Employee employee,List<Employee> list) {
            try {
                list.Add(employee);
            } catch (Exception exp) {
                throw exp;
            }
        }

        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="list"></param>
        public void UpdateEmployee(Employee employee,List<Employee> list) {
            try {
                for (int i = 0; i < list.Count; i++) {
                    if (list[i].EId.StartsWith(employee.EId)) {
                        list.RemoveAt(i);
                        list.Insert(i, employee);
                        break;
                    }
                }
            } catch (Exception exp) {
                throw exp;
            }
        }

        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="list"></param>
        public void DeleteEmployee(Employee employee,List<Employee> list) {
            try {
                for (int i = 0; i < list.Count; i++) {
                    if (list[i].EId.StartsWith(employee.EId)) {
                        list.RemoveAt(i);
                        break;
                    }
                }
            } catch (Exception exp) {
                throw exp;
            }
        }
    }
}
