using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace W6_To_Lua1
{
    public class Function
    {
      
        public string ScriptConvert(string w6Str,string lua_str)
        {
            string pattern = "\\d+\\s+/\\s+\\d+"; //去掉页码的正则表达式规则
            string finallyStr = null;
            //string lua = "dcs_w(";
            string w6_a = "REGS.WRITE(0,0x39,";
            string w6_b = "REGS.WRITE(0,0x15,";
            string w6_c = "REGS.WRITE(0,0x05,";

            string strResult = Regex.Replace(w6Str, pattern, ""); //去页码
            /*            string strResult = w6Str.Replace("//", "--").Replace("\t", "").Replace("\n", ")\n").Replace(w6_a, lua_str).Replace(w6_b, lua_str).Replace(w6_c, lua_str).Replace(")\n)\n", ")\n").Replace("))",")");
                        strResult = Regex.Replace(strResult, "[)]\\n[^D]{0,1}", "");
                        if (!strResult.EndsWith(")"))
                        {
                            strResult = strResult + ")";
                        }*/
            strResult = strResult.Replace("//", "--").Replace("\t", "").Replace("\n", "").Replace(w6_a, lua_str).Replace(w6_b, lua_str).Replace(w6_c, lua_str).Replace(lua_str,")\n" + lua_str).Replace(")--",")\n--").Replace("))",")").Replace("-)", "-");
            if (!strResult.EndsWith(")"))
            {
                strResult = strResult + ")";
            }
            string pattern_ = "0[\\w]{3}[\\s]*--";
            while (!Regex.Match(strResult, pattern_).Value.Equals(""))   //类似0xbb--
            {
                string aa = Regex.Match(strResult, pattern_).Value;
                string bb = Regex.Match(strResult, pattern_).Value.Insert(4, ")");

                strResult = strResult.Replace(aa, bb);
            }
            strResult = Regex.Replace(strResult, "[)][\\s]*[)]", ")");
            string[] arryResult = strResult.Replace("\n", "$").Split('$');
            for (int i = 0; i < arryResult.Length; i++)
            {
               /* if (arryResult[i].Contains("--") && !arryResult[i].Trim().StartsWith("-"))
                {
                    arryResult[i] = arryResult[i].Replace("--", ")--").Trim();
                }*/
                //去掉页码
                /* if (arryResult[i].Contains(" / "))
                 {
                     arryResult[i] = "";
                 }*/

               /* if (Regex.IsMatch(arryResult[i], patten))
                {
                    arryResult[i] = "";
                }*/
                finallyStr = finallyStr + "\n" + (arryResult[i].ToString().Trim() == ")" ? "" : arryResult[i]);

            }
            return finallyStr.Trim();



        }/// <summary>
        /// 脚本转表格格式
        /// </summary>
        /// <param name="w6Str"></param>
        /// <returns></returns>
        public string CodeToTableConvert(string w6Str)
        {
            string retmsg = "";
            string finallyStr = null;
            //string lua = "dcs_w(";
            string str_6601A = "DMIPI.REG_W(";
            string str_6601A_C = "CMIPI.REG_W(";
            string str_6404A = "dcs_w(";
            string befor_str = null;
            if (w6Str.Contains(str_6601A))
            {
                befor_str = str_6601A;
            }
            else if(w6Str.Contains(str_6404A))
            {
                befor_str = str_6404A;
            }
            else if (w6Str.Contains(str_6601A_C))
            {
                befor_str = str_6601A_C;
            }
            else
            {
                retmsg = "请先将代码转换成6601A或6404A格式！";
                return retmsg;
            }
            string str_table = "{[";
            string strResult = w6Str.Replace(befor_str, str_table).Replace(")", "}},");
           
            string[] arryResult = strResult.Replace("\n", "$").Split('$');
            for (int i = 0; i < arryResult.Length; i++)
            {
                //string a = arryResult[i].Trim().Substring(6, 1);
                if (arryResult[i].Trim().Length > 6 && arryResult[i].Trim().Substring(6, 1) == ",")
                {

                    arryResult[i] = arryResult[i].Trim().Remove(6, 1);
                    string a = arryResult[i];

                    
                    arryResult[i] = arryResult[i].Trim().Insert(6, "]={");
                    string b = arryResult[i];



                }
                finallyStr = finallyStr + "\n" + (arryResult[i].ToString().Trim() == ")" ? "" : arryResult[i]);

            }
            return finallyStr.Trim();



        }
        /// <summary>
        /// 格式转换
        /// </summary>
        /// <param name="w6Str"></param>
        /// <returns></returns>
        public string With_Test(string w6Str)
        {
            int bindNum = 16;
            string finallyStr = null;
            for (int i = 1;i <= bindNum - 1 ; i++)
            {
                string w6_r = "GammaRed[" + i.ToString() + " + Pos]";
                string w6_g = "GammaGreen[" + i.ToString() + " + Pos]";
                string w6_b = "GammaBlue[" + i.ToString() + " + Pos]";

                string lua6601_r = "GammaConfig[Mode].Binds[" + (i + 1).ToString() + "].Red";
                string lua6601_g = "GammaConfig[Mode].Binds[" + (i + 1).ToString() + "].Green";
                string lua6601_b = "GammaConfig[Mode].Binds[" + (i + 1).ToString() + "].Blue";

                w6Str = w6Str.Replace(w6_r, lua6601_r).Replace(w6_g, lua6601_g).Replace(w6_b, lua6601_b);
            }
            finallyStr = w6Str;
            return finallyStr;



        }
        /// <summary>
        /// JC(With)格式转换为6601A D-PHY
        /// </summary>
        /// <param name="w6Str"></param>
        /// <param name="lua_str"></param>
        /// <returns></returns>
        public string JcToJzd(string w6Str, string lua_str, string type)
        {
            string finallyStr = null;
            string pattern1 = "";
            if (type == "0x39")
            {
                pattern1 = "REGS.WRITE\\([0|1],"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则
            }
            else
            {
                pattern1 = "REGS.WRITE\\([0|1],[\\s]*(0x39|0x05|0x15),[\\s]*"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则

            }
            string jc_a = "TIME.Delay";
            string jzd_a = jc_a.ToUpper();

            string jc_b = "MIPI.HSLP(LP)";
            string jzd_b = "DMIPI.LP()";

            string jc_c = "MIPI.HSLP(HS)";
            string jzd_c = "DMIPI.HS()";

            string jc_log1 = "MSG.Println";
            string jc_log2 = "MSG.PRINTLN";
            string jzd_log = "LOG.DEBUG";
           
            string jc_e = "REGS.READ";
            string jc_e1 = "F_READ_REG_DATA";
            string jzd_e = "DMIPI.REG_R";
/*
            string jc_if = "F_READ_REG_DATA";
            string jzd_if = "if";*/

            string jc_elif = "ELif";
            string jzd_elif = "elseif";

            string jc_else = "ELSE";
            string jzd_else = "else";
/*
            string jc_for = "FOR";
            string jzd_for = "for";*/

            string jc_end = "END";
            string jzd_end = "end";

            string jc_ret = "RETURN";
            string jzd_ret = jc_ret.ToLower();



            string pattern2 = "tRetResp.strResult[\\s]*=[\\s]*(\"|\')OK(\"|\')"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则
            string pattern3 = "tRetResp.strResult[\\s]*=[\\s]*(\"|\')NG(\"|\')"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则
            string pattern4 = "tRetResp.strResult[\\s]*~=[\\s]*(\"|\')OK(\"|\')"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则

            string pattern5 = @"(LOG.DEBUG[\s]*\()([^\)]*\))"; //匹配LOG.DEBUG("BEforE GAMMA CHECK1 = %d ",CheckSpec)的正则表达式规则
            string pattern_if = @"(IF)([\s]*\([^\n]*)"; //匹配IF (No == 1)的正则表达式规则
            //string pattern_for = @"(FOR)([\s]*)(\()([^TO]*)(TO)([\s]*[^STEP]*)(STEP[\s]*=[\s]*)([^\)]*)(\))"; //匹配FOR(I = 0 TO 27 STEP = 1)的正则表达式规则
            string pattern_for = @"(FOR)([\s]*)(\()([^=]*)(=[\s]*[^\s]*)([\s]*TO)([\s]*[^\s]*)([\s]*STEP[\s]*=[\s]*)([^\)]*)(\))"; //匹配FOR(I = 0 TO 27 STEP = 1)的正则表达式规则

            string pattern_fun = @"(F_[^\)]*)(\):)"; //匹配F_GAMMA_REG_COMPARE(GammaIndex):的正则表达式规则
            string pattern_reg_r = @"(REGS.READ)([\s]*\([\s]*)([0-9],[\s]*)([^,]*,[\s]*[^,]*)(,[\s]*@\$)([\w]*)([\s]*\))"; //匹配REGS.READ (0, J, 8, @$ReadData)的正则表达式规则


            /* pattern3= pattern3+@"""OK""";
             string pattern4 = pattern3 + "\"OK\"" ;
 */
            string strResult = Regex.Replace(w6Str, pattern1, lua_str);
            strResult = Regex.Replace(strResult, pattern2, "tRetResp = 0");
            strResult = Regex.Replace(strResult, pattern3, "tRetResp = -1");
            strResult = Regex.Replace(strResult, pattern4, "tRetResp ~= 0");

            strResult = Regex.Replace(strResult, pattern_if, @"if$2 then");
            //strResult = Regex.Replace(strResult, pattern_for, @"for$2 do");
            strResult = Regex.Replace(strResult, pattern_for, @"for $2$4$5, $7, $9 do");

            strResult = Regex.Replace(strResult, pattern_fun, @"function $1)");
            strResult = Regex.Replace(strResult, pattern_reg_r, @"$6 = DMIPI.REG_R$2$4$7");



            finallyStr = strResult.Replace(jc_a, jzd_a).Replace(jc_b, jzd_b).Replace(jc_c, jzd_c).Replace(jc_log1, jzd_log).Replace(jc_log2, jzd_log).Replace(jc_e, jzd_e).Replace(jc_e1, jzd_e);
            finallyStr = finallyStr.Replace(jc_elif, jzd_elif).Replace(jc_else, jzd_else).Replace(jc_end, jzd_end).Replace(jc_ret, jzd_ret).Replace("//", "--").Replace("$", "").Replace("BREAK","break").Replace("!=","~=");
            finallyStr = finallyStr.Replace(jc_elif, jzd_elif).Replace("TIME.GETTICK()", "TIME.TICK()");

            finallyStr = finallyStr.Replace("&&", " and ").Replace("||", " or ").Replace("TEXT.INIT", "FONT.SET").Replace("TEXT.OUT", "FONT.STRING");

            finallyStr = Regex.Replace(finallyStr, pattern5, @"$1string.format($2)");
            return finallyStr.Trim();
        }
        /// <summary>
        /// 表格转6601
        /// </summary>
        /// <param name="w6Str"></param>
        /// <param name="lua_str"></param>
        /// <returns></returns>
        public string TableTo6601D(string w6Str, string lua_str)
        {
            string finallyStr = null;
          

            string strResult = w6Str.Replace("{[", lua_str).Replace("]={", ",").Replace("}},", ")");
            finallyStr = strResult;
            return finallyStr.Trim();
        }
        /// <summary>
        /// K2平台转表格
        /// </summary>
        /// <param name="w6Str"></param>
        /// <param name="lua_str"></param>
        /// <returns></returns>
        public string K2ToTable(string w6Str, string lua_str)
        {
            string finallyStr = null;
            string pattern1 = "[\\s]*//"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则 
            string pattern2 = "[\\s]+--"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则 
            string pattern3 = "(^[0-9A-Fa-f]{2})(,)"; //匹配第一个CB,正则表达式规则

            // string strResult = w6Str.Replace("//", "--").Trim().Replace("==","--").Trim().Replace("-=", "--");
            string[] arryResult = w6Str.Replace("\n", "$").Split('$');
            for (int i = 0; i < arryResult.Length; i++)
            {

              /*  if (arryResult[i].Split('-').Length >= 2 && !arryResult[i].Trim().StartsWith("-"))
                {
                    arryResult[i] = "{[0x" + arryResult[i];
                }*/
                if (arryResult[i].Contains("["))
                {
                    arryResult[i] = arryResult[i].Replace("[", "{[0x");//"["替换为“{[0x”
                    arryResult[i] = arryResult[i].Replace("]-", "]={0x");//第一个逗号替换为“]={0x”
                }
                else
                {
                    arryResult[i] = arryResult[i].Replace(",", ",0x");//将逗号替换成“,0x”
                    arryResult[i] = Regex.Replace(arryResult[i], pattern3, "{[0x$1]={"); //第一个逗号替换为“]={”
                }

                //arryResult[i] = arryResult[i].Replace("-", ",0x");//剩下的逗号替换成“,0x”

                if (arryResult[i].Contains("//") && !arryResult[i].Trim().StartsWith("/"))
                {
                    arryResult[i] = Regex.Replace(arryResult[i], pattern1, "}},--");
                }
                else if(arryResult[i].Contains("--") && !arryResult[i].Trim().StartsWith("/"))
                {
                    arryResult[i] = Regex.Replace(arryResult[i], pattern2, "}},--");
                }
                else if (!arryResult[i].Trim().StartsWith("/") && !arryResult[i].Trim().StartsWith("=") && (arryResult[i].Trim()!= "") && arryResult[i].StartsWith("{["))
                {
                    arryResult[i] = arryResult[i].Trim() + "}},";
                }
                else if (!arryResult[i].Trim().StartsWith("{["))
                {
                    arryResult[i] = "--" + arryResult[i].Trim();
                }

                finallyStr = finallyStr + "\n" + (arryResult[i].ToString().Trim() == ")" ? "" : arryResult[i]);
                finallyStr = finallyStr.Replace("//", "--").Trim().Replace("==", "--").Trim().Replace("-=", "--");
            }


            //finallyStr = strResult.Replace(jc_a, jzd_a).Replace(jc_b, jzd_b).Replace(jc_c, jzd_c).Replace(jc_d, jzd_d).Replace(jc_e, jzd_e).Replace(jc_b, jzd_b).Replace(jc_c, jzd_c).Replace(jc_d, jzd_d);

            return finallyStr.Trim();
        }
        public string JzcTo6404(string w6Str, string lua_str)
        {
            string finallyStr = null;
            string jzcstr = "PGclient.writeReg('WR_DISPLAY_REG FF ";

            string pattern1 = "dcs_w\\(0[xX][0-9A-Fa-f]{2}[\\s]*"; //匹配dcs_w(0x39 的正则表达式规则 
            string pattern2 = "\\{\\[0x[A-Za-z0-9]{2}[\\s]*,[\\s]*"; //匹配REGS.WRITE(1, 0x39,的正则表达式规则



            string strResult = w6Str.Replace(jzcstr, lua_str).Replace("#", "--").Replace("')", ")");



            string[] arryResult = strResult.Replace("\n", "$").Split('$');
            for (int i = 0; i < arryResult.Length; i++)
            {

                string a = Regex.Match(arryResult[i], pattern1).Value.Trim() + ",0x";
                arryResult[i] = Regex.Replace(arryResult[i], pattern1, a);
                finallyStr = finallyStr + "\n" + (arryResult[i].ToString().Trim() == ")" ? "" : arryResult[i]);
            }
           


            return finallyStr.Trim();
        }
    }
}
