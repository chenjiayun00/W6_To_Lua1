using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace W6_To_Lua1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           /* DataTable dt = new DataTable(); 
            dt = ["0x39","默认"];
            comboBox1.DataSource = dt;*/
           
        }

        private void Btn_To_Lua_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "dcs_w(";
            Function function = new Function();
            finallyStr = function.ScriptConvert(w6Str, luaStr);
            RTBox_Lua.Text = finallyStr;
        }

        private void btn_to_6601_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "DMIPI.REG_W(";
            Function function = new Function();
            finallyStr = function.ScriptConvert(w6Str, luaStr);
            RTBox_Lua.Text = finallyStr;

        }

        private void btn_getQty_Click(object sender, EventArgs e)
        {
           
            string str = RTBox_W6.Text;
            int Qty;
            Qty = str.Split(',').Length;
            lable_qty.Text = Qty.ToString();
        }

        private void btn_To_Table_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            Function function = new Function();
            finallyStr = function.CodeToTableConvert(w6Str);
            RTBox_Lua.Text = finallyStr;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            Function function = new Function();
            finallyStr = function.With_Test(w6Str);
            RTBox_Lua.Text = finallyStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "CMIPI.REG_W(";
            Function function = new Function();
            finallyStr = function.ScriptConvert(w6Str, luaStr);
            RTBox_Lua.Text = finallyStr;

        }

        private void btn_jc_jzd_Click(object sender, EventArgs e)
        {
            //JC格式转换为6601A D-PHY格式
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "DMIPI.REG_W(";
            string type = "默认";
            Function function = new Function();
            if (checkBox1.Checked == true)
            {
                type = "0x39";
            }
            finallyStr = function.JcToJzd(w6Str, luaStr, type);
            RTBox_Lua.Text = finallyStr;
        }

        private void btn_table_to_6601D_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "DMIPI.REG_W(";
            Function function = new Function();
            finallyStr = function.TableTo6601D(w6Str, luaStr);
            RTBox_Lua.Text = finallyStr;
        }

        private void btn_2kToTable_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "DMIPI.REG_W(";
            Function function = new Function();
            finallyStr = function.K2ToTable(w6Str, luaStr);
            RTBox_Lua.Text = finallyStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RTBox_Lua.Text = null;
            string w6Str = RTBox_W6.Text;
            string finallyStr = null;
            string luaStr = "dcs_w(";
            Function function = new Function();
            finallyStr = function.JzcTo6404(w6Str, luaStr);
            RTBox_Lua.Text = finallyStr;
        }
    }
}
