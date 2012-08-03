using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dean.Edwards {

    public partial class Packer : Form {

        public Packer() {
            InitializeComponent();
        }

        private void pack_Click(object sender, System.EventArgs e) {
            ECMAScriptPacker p = new ECMAScriptPacker((ECMAScriptPacker.PackerEncoding)Encoding.SelectedItem, fastDecode.Checked, specialChars.Checked);
            tbResult.Text = p.Pack(tbSource.Text).Replace("\n", "\r\n");
            bSave.Enabled = true;
        }

        private void Packer_Load(object sender, System.EventArgs e) {
            Encoding.Items.Add(ECMAScriptPacker.PackerEncoding.None);
            Encoding.Items.Add(ECMAScriptPacker.PackerEncoding.Numeric);
            Encoding.Items.Add(ECMAScriptPacker.PackerEncoding.Mid);
            Encoding.Items.Add(ECMAScriptPacker.PackerEncoding.Normal);
            Encoding.Items.Add(ECMAScriptPacker.PackerEncoding.HighAscii);
            Encoding.SelectedItem = ECMAScriptPacker.PackerEncoding.Normal;
        }

        private void Encoding_SelectedIndexChanged(object sender, System.EventArgs e) {
            fastDecode.Enabled = ((ECMAScriptPacker.PackerEncoding)Encoding.SelectedItem != ECMAScriptPacker.PackerEncoding.None);
        }

        private void llPaste_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            tbSource.Text = (string)Clipboard.GetDataObject().GetData(typeof(string));
        }

        private void llCopy_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            Clipboard.SetDataObject(tbResult.Text, true);
        }

        private void bClear_Click(object sender, System.EventArgs e) {
            tbResult.Text = tbSource.Text = string.Empty;
            bSave.Enabled = false;
        }

        private void bLoad_Click(object sender, System.EventArgs e) {
            DialogResult r = ofdSource.ShowDialog(this);
            if (r == DialogResult.OK) {
                Stream s = ofdSource.OpenFile();
                TextReader rd = new StreamReader(s);
                string content = rd.ReadToEnd();
                rd.Close();
                s.Close();
                Regex regex = new Regex("([^\r])(\n+)");
                tbSource.Text = regex.Replace(content, new MatchEvaluator(changeUnixLineEndings));
            }
        }

        private string changeUnixLineEndings(Match match) {
            return match.Value.Replace("\n", "\r\n");
        }

        private void bSave_Click(object sender, System.EventArgs e) {
            DialogResult r = sfdResult.ShowDialog(this);
            if (r == DialogResult.OK) {
                Stream s = sfdResult.OpenFile();
                TextWriter rd = new StreamWriter(s);
                rd.Write(tbResult.Text);
                rd.Close();
                s.Close();
            }
        }
    }
}