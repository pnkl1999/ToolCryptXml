using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolCryptXml
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        public Form1()
        {
            InitializeComponent();
            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private byte[] Compress(byte[] data)
        {
            using (var output = new MemoryStream())
            {
                using (var gzip = new GZipStream(output, CompressionMode.Compress))
                {
                    gzip.Write(data, 0, data.Length);
                }
                return output.ToArray();
            }
        }

        private byte[] Uncompress(byte[] data)
        {
            using (var input = new MemoryStream(data))
            using (var output = new MemoryStream())
            {
                using (var gzip = new GZipStream(input, CompressionMode.Decompress))
                {
                    gzip.CopyTo(output);
                }
                return output.ToArray();
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "XML Files|*.xml";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] data = File.ReadAllBytes(this.openFileDialog.FileName);
                byte[] compressedData = Compress(data);

                string originalFileName = Path.GetFileNameWithoutExtension(this.openFileDialog.FileName);
                string suggestedFileName = originalFileName + "_out.xml";

                this.saveFileDialog.Filter = "Compressed Files|*.xml";
                this.saveFileDialog.FileName = suggestedFileName;

                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(this.saveFileDialog.FileName, compressedData);
                    MessageBox.Show("File compressed successfully!");
                }
            }
        }

        private void btnUncompress_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Compressed Files|*.xml";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] data = File.ReadAllBytes(this.openFileDialog.FileName);
                byte[] uncompressedData = Uncompress(data);

                string originalFileName = Path.GetFileNameWithoutExtension(this.openFileDialog.FileName);
                string suggestedFileName = originalFileName + "_out.xml";

                this.saveFileDialog.Filter = "XML Files|*.xml";
                this.saveFileDialog.FileName = suggestedFileName;

                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(this.saveFileDialog.FileName, uncompressedData);
                    MessageBox.Show("File uncompressed successfully!");
                }
            }
        }

        private void lblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/CyR.Diggory/");
        }
    }
}