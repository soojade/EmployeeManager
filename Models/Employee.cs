using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models {
    /// <summary>
    /// 实体类：只有字段没有方法，用于表示实体信息的类
    /// </summary>
    public class Employee {
        public string EId { get; set; }
        public string EName { get; set; }
        public string ESex { get; set; }
        public string EPhone { get; set; }
        public DateTime EBDay { get; set; }
        public string EAddr { get; set; }
        public string EPhotoPath { get; set; }
    }
}
