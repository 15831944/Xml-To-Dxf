using System;
using System.IO;
using System.Windows.Forms;
using netDxf;
using netDxf.Entities;

namespace ParcelsConverter
{
    public partial class Win_Prop : Form
    {
        ulong centerX = 0;
        ulong centerY = 0;
        int centerCounter = 0;
    

        public Win_Prop()
        {
            InitializeComponent();
            textBoxFrom.Text = main.Path;
            textBoxTo.Text = main.Path.Replace(".xml",".dxf");
        }

        private void button_export(object sender, EventArgs e)
        {
            DxfDocument Doc = new DxfDocument();
           
            /* Отрисовка участков */
            for (int z = 0; z < MyXmlReader.spatials.Count; z++)
            {
                LwPolyline parcel = new LwPolyline();
                
                foreach (var Point in MyXmlReader.spatials[z].Points)
                {
                    centerX += (ulong)Point.X;
                    centerY += (ulong)Point.Y;
                    centerCounter++;
                    if (Switch.Checked)//Перевернуть X Y
                    {
                        parcel.Vertexes.Add(new LwPolylineVertex(new Vector2(Point.Y, Point.X)));
                    }
                    else
                    {
                        parcel.Vertexes.Add(new LwPolylineVertex(Point));
                    }
                    
                }
                Doc.AddEntity(parcel);
            }

            /* Создаем надпись кад. номера */
            Text cad_number = new Text();
            cad_number.Value = MyXmlReader.CadastralNumber;
            cad_number.Alignment = TextAlignment.MiddleCenter;
            cad_number.Height = 2.5d;
            if (Switch.Checked)
            {
                Vector3 textPosition = new Vector3((double)centerY / centerCounter, (double)centerX / centerCounter, 0);
                cad_number.Position = textPosition;
            }
            else
            {
                Vector3 textPosition = new Vector3((double)centerX / centerCounter, (double)centerY / centerCounter, 0);
                cad_number.Position = textPosition;
            }

            Doc.AddEntity(cad_number);

            try
            {
                Doc.Save(textBoxTo.Text);
            }
            catch (IOException x)
            {
                MessageBox.Show(x.Message);
            }
            Application.Exit();
        }

        
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Файлы xml (*.xml)|*.xml";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;
            textBoxFrom.Text = openFile.FileName;
        }

        private void Saveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Файлы dxf (*.dxf)|*.dxf";
            if (saveFile.ShowDialog() != DialogResult.OK)
                return;
            textBoxTo.Text = saveFile.FileName;
        }
    }
}
