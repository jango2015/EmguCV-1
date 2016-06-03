using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace EmguCV
{
    public partial class Form1 : Form
    {
        private Capture capturaDaCamera;        //pega imagens da camera como frames
        private bool capturaEmProgresso;        //checa se a captura esta sendo executada
        private HaarCascade haar;
        private int tamanhoDaJanela = 25;
        private double fatorDeEscala = 1.1;
        private int numeroMinimoDeVizinhos = 4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            haar = new HaarCascade(Environment.CurrentDirectory + "\\haarcascade_frontalface_alt_tree.xml");
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProcessarFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> frame = capturaDaCamera.QueryFrame();
            imageBox1.Image = frame;
            if (frame != null)
            {
                //converte a imagem para uma escala em cinza
                Image<Gray, byte> frameCinza = frame.Convert<Gray, byte>();

                //numeroMinimoDeVizinhos = int.Parse(comboBoxMinViz.SelectedText);
                //fatorDeEscala = int.Parse(comboBoxEscala.SelectedText);
                //tamanhoDaJanela = int.Parse(textBoxMinJanela.Text);


                //detecta faces apartir da imagem em cinza e guarda elas em um array do tipo var
                var faces =  frameCinza.DetectHaarCascade(haar, 1.1, 4, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(25, 25))[0];
                int TotalFaces = faces.Length;
                numFacesIdentificadas.Text = TotalFaces.ToString();
               // MessageBox.Show("Total faces detected: " + TotalFaces.ToString());
                foreach (var face in faces)
                {
                    frame.Draw(face.rect, new Bgr(Color.Green), 3);
                }
            }
            imageBox1.Image = frame;
        }

        /*
        Para mostrar a quantidade de faces identificadas em uma chamada de x funcao:
        int TotalFaces = faces.Length;
        MessageBox.Show("Total faces detected: " + TotalFaces.ToString());
        */
        
        //Mostra a imagem em Windows Form Picturebox
        //pictureBox1.Image = ImageFrame.ToBitmap();
        //Para salvar a imagem: Frame.Save(@"E:\MyPic.jpg");

        private void iniciarBT_Click(object sender, EventArgs e)
        {
            
            #region if capturaDaCamera is not created, create it now
            if (capturaDaCamera == null)
            {
                try
                {
                    capturaDaCamera = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capturaDaCamera != null)
            {
                if (capturaEmProgresso)
                {  //if camera is getting frames then stop the capture and set button Text
                    // "Start" for resuming capture
                    iniciarBT.Text = "Iniciar!"; //
                    Application.Idle -= ProcessarFrame;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
                    iniciarBT.Text = "Parar";
                    Application.Idle += ProcessarFrame;
                }

                capturaEmProgresso = !capturaEmProgresso;
            }
        }

        private void ReleaseData()
        {
            if (capturaDaCamera != null)
                capturaDaCamera.Dispose();
        }

        private void salvarImagem_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> Imagem = capturaDaCamera.QueryFrame();
            Imagem.Save(Environment.CurrentDirectory + "\\imagem.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
