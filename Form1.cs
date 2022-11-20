using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

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
            string result = meaning[0];
            for (int i = 1; i < meaning.Length; i++)
            {
                result += "\n" + meaning[i];
            }
            rtbMeaning.Text = result;
        }
        private void DictEnVi_Load(object sender, EventArgs e)
        {
            SetData();
            lbListWords.Items.AddRange(dict.Keys.ToArray());
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
                StreamReader sr = new StreamReader("star_anhviet.txt", Encoding.UTF8);
                string lines = sr.ReadLine();
                while (lines!= null)
                {
                    string[] words = lines.Split('\t');
                    if (dict.ContainsKey(words[0]) == true && dict.ContainsValue(words[1]) == false)
                    {
                        dict.Add(words[0] + " ", words[1]);
                    }

                    else
                    {
                        dict.Add(words[0], words[1]);
                    }
                    lines = sr.ReadLine();
                }
            }
            catch (Exception ex) { }
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/maxrave-dev/DictionaryEnVi";
            Process.Start(githubUrl);
        }

        private void danhSáchNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lead: Nguyễn Đức Tuấn Minh\nNguyễn Thị Phương Thảo\nLê Bá Kha\nThân Trọng Đức", "Danh sách thành viên");
        }

        private void starDictViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/dynamotn/stardict-vi";
            Process.Start(githubUrl);
        }

        private void starDictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "http://www.huzheng.org/stardict/";
            Process.Start(url);
        }
    }
}
