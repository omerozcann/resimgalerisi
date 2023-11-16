using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace resimgalerisi
{
    public partial class rgFrm : Form
    {
        ImageList il = new ImageList();
        List<Image> ilorj= new List<Image>();
        public rgFrm()
        {
            InitializeComponent();
        }

        private void klasoracbtn_Click(object sender, EventArgs e)
        {
              FolderBrowserDialog fb=new FolderBrowserDialog();
              fb.ShowDialog();
            if(fb.SelectedPath!="")
            {
                 String[]liste=Directory.GetFiles(fb.SelectedPath,"*.*",SearchOption.AllDirectories);
               
                il.ImageSize = new Size(64, 64);             
                
                List<String> resimler = new List<string>();
                foreach (var item in liste)
                {
                    String uzanti = Path.GetExtension(item);                    
                    if(uzanti==".jpg"||uzanti==".png"||uzanti==".gif"|| uzanti == ".JPG")
                    {                        
                        Image img=Image.FromFile(item);                       
                        il.Images.Add(img);
                        resimler.Add(item);
                        ilorj.Add(img);
                    }
                }
                //---------------------------------------------------------------------------------------------
                           
                resimlistlv.LargeImageList = il;
                for(int i=0;i<resimler.Count;i++)
                {
                    resimlistlv.Items.Add(Path.GetFileName(resimler[i]), i);
                }            
            }
        }

        private void resimlistlv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resimlistlv_Click(object sender, EventArgs e)
        {
            if(resimlistlv.SelectedItems.Count > 0)
            {
                int index = resimlistlv.SelectedItems[0].Index;
                resimpb.BackgroundImage = ilorj[index];
            }            
        }
    }
}
