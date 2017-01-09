using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Делегаты
{
    delegate void MethodDelegate();
    class Fly
    {
        MethodDelegate TypeDesigner;

        int _speed;
        public int Speed
        {
            get
            {
                return _speed;
            }
            set { if (_speed >= 0) _speed = value; }
        }

        int _height;
        public int Height
        {
            get { return _height; }
            set { if (_height >= 0) _height = value; }
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set { if (_name != null) _name = value; }
        }

        public Fly(int speed)
        {
            this.Speed = speed;
            //Правка 1 - зачем ты писал += какой в этом смысл тут??? достаточно только = ИМХО и все также будет работать
            TypeDesigner = Mes1;
            MessageBox.Show("Михаил, внес изменение!");

            //первый конструктор
        }
        public Fly(int speed, int height)
        {

            //а также переписал конструктор с двумя параметрами

            this.Speed = speed;
            this.Height = height;
            TypeDesigner = Mes2;
        }
        public Fly(int speed, int height, string name)
        {

            // переписал конструктор с 3 параметрами
            this.Speed = speed;
            this.Height = height;
            this.Name = name;
            TypeDesigner = Mes3;
        }
        public void ShowConstructor()
        {
            
            //переписал шоу конструктор

            TypeDesigner();
        }

        public void Mes1()
        {
            MessageBox.Show("Это конструктор с одним параметром!");
        }
        public void Mes2()
        {
            MessageBox.Show("Это конструктор с двумя параметрами!");
        }
        public void Mes3()
        {
            MessageBox.Show("Это конструктор с тремя параметрами!");
        }
    }
}
