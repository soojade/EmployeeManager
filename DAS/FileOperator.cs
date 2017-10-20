using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Models;

namespace DAS
{
    public class FileOperator
    {
        /// <summary>
        /// 读取文件内容 初始化实例 并存入list 返回
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public List<Employee> ReadFile(string file) {
            List<Employee> list = new List<Employee>();
            string line = "";

            try {
                StreamReader str = new StreamReader(file, Encoding.Default);
                line = str.ReadLine();
                while (line!=null) {
                    string[] employee = line.Split(',');

                    list.Add(new Employee {
                        EId = employee[0],
                        EName = employee[1],
                        ESex = employee[2],
                        EPhone = employee[3],
                        EBDay = Convert.ToDateTime(employee[4]),
                        EAddr = employee[5],
                        EPhotoPath = employee[6]
                    });
                    line = str.ReadLine();
                }
                str.Close();
            } catch (Exception exp) {

                throw exp;
            }
            return list;
        }
    }
}
