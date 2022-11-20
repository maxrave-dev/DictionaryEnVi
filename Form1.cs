using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary2
{
    public partial class DictEnVi : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public DictEnVi()
        {
            InitializeComponent();
        }
        private void lbListWords_Click(object sender, EventArgs e)
        {
            string word = lbListWords.SelectedItem.ToString();
            var preMeaning = dict[word];
            preMeaning = preMeaning.Replace(@"\n", ".");
            string[] meaning = preMeaning.Split('.');
            string result = "";
            for (int i = 0; i < meaning.Length; i++)
            {
                result += "\n" + meaning[i];
            }
            rtbMeaning.Text = result;
        }
        private void DictEnVi_Load(object sender, EventArgs e)
        {
            SetData();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lbListWords.Items.Clear();
                string word = tbSearch.Text.ToLower();
                foreach (var item in dict)
                {
                    if (item.Key.ToLower().Contains(word) == true || item.Key.ToLower() == word)
                    {
                        lbListWords.Items.Add(item.Key.ToString());
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy từ này");
            }
        }
        private void SetData()
        {
            try
            {
                //var path = @"C:\Users\mxrvm\Desktop\Code Project\C#\CTDL và Giải thuật\Dictionary\Dictionary2\star_anhviet.txt";
                string[] lines = File.ReadAllLines("star_anhviet.txt", Encoding.UTF8);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] devide = lines[i].Split('\t');
                    dict.Add(devide[0], devide[1]);
                }
            }
            catch (Exception ex) { }
        }
    }
}
