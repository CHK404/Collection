using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_14_Collection
{
    public class loginData_1<ID, PW>
    {
        public Dictionary<ID, PW> id_PW = new Dictionary<ID, PW>();

        public void AddPW(ID id, PW pw)
        {
            id_PW[id] = pw;
        }
    }
    public class logindata_2<ID, PN>
    {
        public Dictionary<ID, PN> id_PN = new Dictionary<ID, PN>();
        public void AddPN(ID id, PN pn)
        {
            id_PN[id] = pn;
        }
        public bool numberExist(ID id)
        {
            return id_PN.ContainsKey(id);
        }
        public void printInfo()
        {
            foreach (var item in id_PN)
            {
                MessageBox.Show($"ID: {item.Key}\r\nPhone Number: {item.Value}");
            }
        }
    }
}
