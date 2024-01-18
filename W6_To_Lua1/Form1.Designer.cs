using System;

namespace W6_To_Lua1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RTBox_W6 = new System.Windows.Forms.RichTextBox();
            this.RTBox_Lua = new System.Windows.Forms.RichTextBox();
            this.btn_To_Lua = new System.Windows.Forms.Button();
            this.btn_to_6601 = new System.Windows.Forms.Button();
            this.btn_getQty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lable_qty = new System.Windows.Forms.Label();
            this.btn_To_Table = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_jc_jzd = new System.Windows.Forms.Button();
            this.btn_table_to_6601D = new System.Windows.Forms.Button();
            this.btn_2kToTable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RTBox_W6
            // 
            this.RTBox_W6.AccessibleName = "";
            this.RTBox_W6.Location = new System.Drawing.Point(57, 58);
            this.RTBox_W6.Name = "RTBox_W6";
            this.RTBox_W6.Size = new System.Drawing.Size(464, 544);
            this.RTBox_W6.TabIndex = 0;
            this.RTBox_W6.Text = "";
            this.RTBox_W6.WordWrap = false;
            // 
            // RTBox_Lua
            // 
            this.RTBox_Lua.Location = new System.Drawing.Point(706, 48);
            this.RTBox_Lua.Name = "RTBox_Lua";
            this.RTBox_Lua.Size = new System.Drawing.Size(419, 544);
            this.RTBox_Lua.TabIndex = 1;
            this.RTBox_Lua.Text = "";
            this.RTBox_Lua.WordWrap = false;
            // 
            // btn_To_Lua
            // 
            this.btn_To_Lua.Location = new System.Drawing.Point(554, 93);
            this.btn_To_Lua.Name = "btn_To_Lua";
            this.btn_To_Lua.Size = new System.Drawing.Size(104, 43);
            this.btn_To_Lua.TabIndex = 2;
            this.btn_To_Lua.Text = "W6 转 6404";
            this.btn_To_Lua.UseVisualStyleBackColor = true;
            this.btn_To_Lua.Click += new System.EventHandler(this.Btn_To_Lua_Click);
            // 
            // btn_to_6601
            // 
            this.btn_to_6601.Location = new System.Drawing.Point(554, 156);
            this.btn_to_6601.Name = "btn_to_6601";
            this.btn_to_6601.Size = new System.Drawing.Size(104, 43);
            this.btn_to_6601.TabIndex = 3;
            this.btn_to_6601.Text = "W6 转 6601-D";
            this.btn_to_6601.UseVisualStyleBackColor = true;
            this.btn_to_6601.Click += new System.EventHandler(this.btn_to_6601_Click);
            // 
            // btn_getQty
            // 
            this.btn_getQty.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getQty.Location = new System.Drawing.Point(235, 610);
            this.btn_getQty.Name = "btn_getQty";
            this.btn_getQty.Size = new System.Drawing.Size(101, 35);
            this.btn_getQty.TabIndex = 4;
            this.btn_getQty.Text = "获取项目个数";
            this.btn_getQty.UseVisualStyleBackColor = true;
            this.btn_getQty.Click += new System.EventHandler(this.btn_getQty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(387, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "数目：";
            // 
            // lable_qty
            // 
            this.lable_qty.AutoSize = true;
            this.lable_qty.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_qty.Location = new System.Drawing.Point(444, 620);
            this.lable_qty.Name = "lable_qty";
            this.lable_qty.Size = new System.Drawing.Size(14, 14);
            this.lable_qty.TabIndex = 6;
            this.lable_qty.Text = "0";
            // 
            // btn_To_Table
            // 
            this.btn_To_Table.Location = new System.Drawing.Point(554, 294);
            this.btn_To_Table.Name = "btn_To_Table";
            this.btn_To_Table.Size = new System.Drawing.Size(104, 38);
            this.btn_To_Table.TabIndex = 7;
            this.btn_To_Table.Text = "转表格";
            this.btn_To_Table.UseVisualStyleBackColor = true;
            this.btn_To_Table.Click += new System.EventHandler(this.btn_To_Table_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(565, 569);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 8;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "W6 转 6601-C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_jc_jzd
            // 
            this.btn_jc_jzd.Location = new System.Drawing.Point(554, 356);
            this.btn_jc_jzd.Name = "btn_jc_jzd";
            this.btn_jc_jzd.Size = new System.Drawing.Size(104, 38);
            this.btn_jc_jzd.TabIndex = 10;
            this.btn_jc_jzd.Text = "JC-JZD";
            this.btn_jc_jzd.UseVisualStyleBackColor = true;
            this.btn_jc_jzd.Click += new System.EventHandler(this.btn_jc_jzd_Click);
            // 
            // btn_table_to_6601D
            // 
            this.btn_table_to_6601D.Location = new System.Drawing.Point(554, 463);
            this.btn_table_to_6601D.Name = "btn_table_to_6601D";
            this.btn_table_to_6601D.Size = new System.Drawing.Size(104, 38);
            this.btn_table_to_6601D.TabIndex = 11;
            this.btn_table_to_6601D.Text = "表格 转 6601-D";
            this.btn_table_to_6601D.UseVisualStyleBackColor = true;
            this.btn_table_to_6601D.Click += new System.EventHandler(this.btn_table_to_6601D_Click);
            // 
            // btn_2kToTable
            // 
            this.btn_2kToTable.Location = new System.Drawing.Point(554, 410);
            this.btn_2kToTable.Name = "btn_2kToTable";
            this.btn_2kToTable.Size = new System.Drawing.Size(104, 38);
            this.btn_2kToTable.TabIndex = 12;
            this.btn_2kToTable.Text = "2K 转 表格";
            this.btn_2kToTable.UseVisualStyleBackColor = true;
            this.btn_2kToTable.Click += new System.EventHandler(this.btn_2kToTable_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "JZC 转 6404";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(554, 620);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 20);
            this.comboBox1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(554, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "0x39";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 698);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_2kToTable);
            this.Controls.Add(this.btn_table_to_6601D);
            this.Controls.Add(this.btn_jc_jzd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_To_Table);
            this.Controls.Add(this.lable_qty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_getQty);
            this.Controls.Add(this.btn_to_6601);
            this.Controls.Add(this.btn_To_Lua);
            this.Controls.Add(this.RTBox_Lua);
            this.Controls.Add(this.RTBox_W6);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion
        private System.Windows.Forms.RichTextBox RTBox_Lua;
        private System.Windows.Forms.Button btn_To_Lua;
        private System.Windows.Forms.Button btn_to_6601;
        private System.Windows.Forms.RichTextBox RTBox_W6;
        private System.Windows.Forms.Button btn_getQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_qty;
        private System.Windows.Forms.Button btn_To_Table;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_jc_jzd;
        private System.Windows.Forms.Button btn_table_to_6601D;
        private System.Windows.Forms.Button btn_2kToTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

