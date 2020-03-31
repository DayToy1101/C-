using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Employee_ori
    {
        private int m_salary;
        private Manager_ori manager;

        public int Salary
        {
            get { return m_salary; }
            set { m_salary = value; }
        }
        public Employee_ori(Manager_ori manager)
        {
            Console.WriteLine("创建了一个员工对象");
            m_salary = 3000;
            this.manager = manager;
        }
        public void playGame()
        {
            Console.WriteLine("游戏真好玩");
            manager.deductSalary(this);
            Console.WriteLine("员工薪水变为：" + m_salary);
        }
    }
}
