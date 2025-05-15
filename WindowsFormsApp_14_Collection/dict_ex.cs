using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_14_Collection
{
    public class loginData_1<TKey, TValue>
    {
        public Dictionary<TKey, TValue> id_PW = new Dictionary<TKey, TValue>();

        public void AddPW(TKey id, TValue pw)
        {
            id_PW[id] = pw;
        }
        public bool idExist(TKey id)
        {
            return id_PW.ContainsKey(id);
        }
        public bool pwRight(TKey id, out TValue pw)
        {
            return id_PW.TryGetValue(id,out pw);
        }
    }
    public class logindata_2<TKey, TValue>
    {
        public Dictionary<TKey, TValue> id_PN = new Dictionary<TKey, TValue>();
        public void AddPN(TKey id, TValue pn)
        {
            id_PN[id] = pn;
        }
        public void printInfo(TKey id, out TValue pn)
        {
            if (id_PN.TryGetValue(id, out pn))
            {
                MessageBox.Show($"ID: {id}\r\nPhone Number: {pn}");
            }
        }
    }
}
