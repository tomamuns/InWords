/**********************************************************************************/
/* Copyright ©  2020, Muhammed Abdullah Al Mamun (#tomamuns)
 * 
 * Organization          : infosec4all.net
 * 
 * Development Framework : DOT Net 4.0 & above
 * 
 * Development Language  : C#
 * 
 * Description           : This application will convert integer amount into word
 * both in english and bangla format
 * 
 * Limitation            : It can converty upto 14 digits number/amount into word 
 * ////////////////////////////////////////////////////////////////////////////////*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace InWords
{
    public partial class InWordsForm : Form
    {
        /// <summary>
        /// Fixed Numerals both for English And Bangla
        /// </summary>
        string[] _fixed_numerals_english            = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] _fixed_numerals_20_30_40_english   = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty ", "Ninety " };
        string[] _fixed_numerals_bangla             = { "শূন্য", "এক ", "দুই ", "তিন ", "চার ", "পাঁচ ", "ছয় ", "সাত ", "আট ", "নয় ", "দশ ", "এগারো ", "বারো ", "তেরো ", "চৌদ্দ ", "পনেরো ", "ষোল ", "সতেরো ", "আঠারো ", "ঊনিশ ", "বিশ ", "একুশ ", "বাইশ ", "তেইশ ", "চব্বিশ ", "পঁচিশ ", "ছাব্বিশ ", "সাতাশ ", "আঠাশ ", "ঊনত্রিশ ", "ত্রিশ ", "একত্রিশ ", "বত্রিশ ", "তেত্রিশ ", "চৌত্রিশ ", "পঁয়ত্রিশ ", "ছত্রিশ ", "সাইত্রিশ ", "আটত্রিশ ", "ঊনচল্লিশ ", "চল্লিশ ", "একচল্লিশ ", "বিয়াল্লিশ ", "তেতাল্লিশ ", "চুয়াল্লিশ ", "পঁয়তাল্লিশ ", "ছেচল্লিশ ", "সাতচল্লিশ ", "আটচল্লিশ ", "ঊনপঞ্চাশ ", "পঞ্চাশ ", "একান্ন", "বাহান্ন", "তিপ্পান্ন", "চুয়ান্ন", "পঞ্চান্ন", "ছাপ্পান্ন", "সাতান্ন", "আটান্ন", "উনষাইট", "ষাইট", "একষাট্টি", "বাষট্টি", "তেষট্টি", "চৌষট্টি", "পঁয়ষট্টি", "ছেষট্টি", "সাতষট্টি", "আটষট্টি", "উনসত্তর", "সত্তর", "একাত্তর", "বাহাত্তর", "তিয়াত্তর", "চুয়াত্তর", "পঁচাত্তর", "ছিয়াত্তর", "সাতাত্তর", "আটাত্তর", "উনআশি", "আশি", "একাশি", "বিরাশি", "তিরাশি", "চুরাশি", "পঁচাশি", "ছিয়াশি", "সাতাশি", "আটআশি", "উননব্বই", "নব্বই", "একানব্বই", "বিরানব্বই", "তিরানব্বই", "চুরানব্বই", "পঁচানব্বই", "ছিয়ানব্বই", "সাতানব্বই", "আটানব্বই", "নিরানব্বই" };

        /// <summary>
        /// Declare the word to english voice variable
        /// </summary>
        SpeechSynthesizer speechSynthesizerObj = new SpeechSynthesizer();

        public InWordsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will display integer number/amount into english word format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayButton_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.Dispose();
            string _number = numberTextBox.Text.ToString();
            int _len = _number.Length;
            
            if (_len < 1)
            {
                MessageBox.Show("Enter Numeric Digit", "In Words", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberTextBox.Focus();
            }
            else
            {
                int i = _len - 1;

                string tmp_result = InWords(_number, _number.Length - 1, 1, "", false, false);
                inWordsTextBox.Text = tmp_result.Replace("  ", " ").Trim();
            }
        } ///end of Method

        /// <summary>
        /// This method will display integer number/amount into english word format as well as speak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            string _number = numberTextBox.Text.ToString();
            int _len = _number.Length;

            if (_len < 1)
            {
                MessageBox.Show("Enter Numeric Digit", "In Words", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberTextBox.Focus();
            }
            else
            {
                int i = _len - 1;

                string tmp_result = InWords(_number, _number.Length - 1, 1, "", false, false);
                inWordsTextBox.Text = tmp_result.Replace("  ", " ").Trim();

                string _select_voice2 = "Microsoft Zira Desktop";
                if (maleVoiceRadioButton.Checked == true)
                {
                    _select_voice2 = "Microsoft David Desktop";
                }

                //Disposes the SpeechSynthesizer object   
                speechSynthesizerObj.Dispose();
                if (inWordsTextBox.Text.Trim() != "")
                {
                    speechSynthesizerObj = new SpeechSynthesizer();
                    speechSynthesizerObj.SelectVoice(_select_voice2);
                    speechSynthesizerObj.SpeakAsync(inWordsTextBox.Text.Trim());
                }
            }
        }

        /// <summary>
        /// This method will display integer number/amount into bangla word format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void banglaDisplayButton_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.Dispose();
            string _number = numberTextBox.Text.ToString();
            int _len = _number.Length;

            if (_len < 1)
            {
                MessageBox.Show("Enter Numeric Digit", "In Words", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberTextBox.Focus();
            }
            else
            {
                int i = _len - 1;

                string tmp_result = InWords(_number, _number.Length - 1, 1, "", false, false, false);
                inWordsTextBox.Text = tmp_result.Replace("  ", " ").Trim();
            }
        }//end method
        
        /// <summary>
        /// This method will reset the contents into default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = "";
            inWordsTextBox.Text = "";
            speechSynthesizerObj.Dispose();
            femaleVoiceRadioButton.Checked = true;
        }

        /// <summary>
        /// This method will prevent to enter any other characters other than number only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        /// <summary>
        /// This back track method will convert integer number/amount into either english or bangla word based on the provided parameter
        /// </summary>
        /// <param name="number"></param>
        /// <param name="len"></param>
        /// <param name="depth"></param>
        /// <param name="words"></param>
        /// <param name="and_flg"></param>
        /// <param name="and_done"></param>
        /// <param name="is_english"></param>
        /// <returns></returns>
        private string InWords(string number, int len, int depth, string words, bool and_flg, bool and_done, bool is_english = true)
        {
            if (len > -1)
            {
                int digit_position = 0;

                if (depth == 2 || depth == 6)
                {
                    digit_position = Convert.ToInt32(number.Substring(len, 1));
                    len = len - 1;
                }
                else if (len - 1 > -1)
                {
                    digit_position = Convert.ToInt32(number.Substring(len - 1, 2));
                    len = len - 2;
                }
                else
                {
                    digit_position = Convert.ToInt32(number.Substring(len, 1));
                    len = len - 2;
                }

                string tmp_words = "";
                string _tmp_numeral = "";
                string _tmp_and = "";

                if (digit_position > 0)
                {
                    switch (depth)
                    {
                        case 2:
                        case 6:
                            _tmp_numeral = is_english == true ? " Hundred " : "শ ";
                            break;
                        case 3:
                        case 7:
                            _tmp_numeral = is_english == true ? " Thousand " : " হাজার ";
                            break;
                        case 4:
                        case 8:
                            _tmp_numeral = is_english == true ? " Lac " : " লাখ ";
                            break;
                        case 5:
                            _tmp_numeral = is_english == true ? " Crore ": " কোটি ";
                            break;
                        default:
                            _tmp_numeral = " ";
                            break;
                    }
                    if (is_english == true && and_flg == true && and_done == false)
                    {
                        _tmp_and = " and ";
                        and_done = true;
                    }
                    string sub_tmp_words = is_english == true ? this.GetWord(digit_position.ToString().Trim()) : this.GetBanglaWord(digit_position.ToString().Trim());
                    tmp_words = sub_tmp_words + _tmp_numeral + _tmp_and + words;
                    and_flg = true;
                }
                else
                {
                    tmp_words = words;
                }
                return InWords(number, len, depth + 1, tmp_words, and_flg, and_done, is_english);
            }
            return words;
        } //end method

        /// <summary>
        /// This method will converty digit into english word
        /// </summary>
        /// <param name="_str_num"></param>
        /// <returns></returns>
        private string GetWord(string _str_num)
        {
            int _len = _str_num.Length;
            if (_len < 1 || _len > 2)
            {
                return "";
            }

            int _num = Convert.ToInt32(_str_num);
            if (_num > 0 && _num < 20)
            {
                return _fixed_numerals_english[_num].ToString().Trim();
            }
            else if (_num >= 20 && _num <= 99)
            {
                int _1_ind = _num / 10;
                int _2_ind = _num % 10;
                string _tmp_str = _fixed_numerals_20_30_40_english[_1_ind].ToString().Trim();
                if (_2_ind != 0)
                {
                    _tmp_str += " " + _fixed_numerals_english[_2_ind].ToString().Trim();
                }
                return _tmp_str;
            }

            return "";
        } //end method

        /// <summary>
        /// This method will converty digit into bangla word
        /// </summary>
        /// <param name="_str_num"></param>
        /// <returns></returns>
        private string GetBanglaWord(string _str_num)
        {
            int _len = _str_num.Length;
            if (_len < 1 || _len > 2)
            {
                return "";
            }
            int _num = Convert.ToInt32(_str_num);
            return _fixed_numerals_bangla[_num].ToString().Trim();
        } //end method

    } //end class
} //end namespace
