using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //封装通过访问修饰符实现
            //public 对所有范围只要是引用到了就可以访问
            Person person = new Person();
            person.getAge();
            //private外部不可以访问
            //internal在程序集中可以访问
            //protected在本身类和继承的类中可以使用
            //Internal protected可以在程序集使用，也可对于他的继承类可见。
        }
    }

    //public例子,可以修饰字段，也可以修饰方法
    class Person {
        private int age;
        protected int anme;

        //通过属性访问私有字段
        public int Age {
            get { return age;}
            set { age = value; }
        }
        public int getAge() {
            return age;
        }
    }

    class Man : Person {
        public int getName() {
            return base.anme;
        }
    }
}
