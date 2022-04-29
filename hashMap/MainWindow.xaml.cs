using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hashMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
            arrayList = new ArrayList();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            //Add data
            //Pann = Key (คล้าย กับ Index) -> Key ห้ามซ้ำกัน , glasses = data (value)
            //hashtable.Add("Pann","glasses");
            //hashtable.Add("Pann1", "glasses1");
            //hashtable.Add("Pann2", "glasses2");
            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection)
            {
                //แสดง data ที่อยู่ในแต่ละ Key ของ hashtable
                //MessageBox.Show(hashtable[key].ToString());
                //arrayList.Add(hashtable[key].ToString());
                Console.WriteLine(key);
                if (txtKey.Text == key)
                {
                    Console.WriteLine("Fail");
                    return;
                }
                Console.WriteLine("on going");
            }
            Console.WriteLine("Added");
            hashtable.Add(txtKey.Text, txtValue.Text);
            return;
            //MessageBox.Show(hashtable[ke])
            /*if (txtKey.Text != hashtable[key].ToString())
            {
                hashtable.Add(txtKey.Text, txtValue.Text);
            }*/
            //hashtable.Add(txtKey.Text, txtValue.Text);*/
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            //Remove 
            //hashtable.Remove("Pann");
            hashtable.Remove(txtKey.Text);
        }

        private void Showall(object sender, RoutedEventArgs e)
        {
            //เอา Key ทั้งหมดใน hashtable ไปใส่ใน icollection
            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection)
            {
                //แสดง data ที่อยู่ในแต่ละ Key ของ hashtable
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
