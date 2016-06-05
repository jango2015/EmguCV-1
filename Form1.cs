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
        private Double fatorDeEscala = 1.1;
        private int numeroMinimoDeVizinhos = 4;

        Image<Bgr, Byte> frame;
        Image<Gray, Byte> frameCinza;

        Bitmap[] FacesExt;
        int numFace = 0;


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


        private void carregarImagemBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image InputImg = Image.FromFile(openFileDialog1.FileName);
                frame = new Image<Bgr, byte>(new Bitmap(InputImg));
                frameCinza = frame.Convert<Gray, byte>();
                ProcessarFrame();
            }
        }

        private void carregarFrameCamera(object sender, EventArgs e)
        {
            frame = capturaDaCamera.QueryFrame();
            if (frame != null)
            {
                frameCinza = frame.Convert<Gray, byte>();
                ProcessarFrame();
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// ////////////////////FUNCAO USADA PARA PROCESSAR AS FACES//////////////////////////////////////////////
        /// </summary>
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ProcessarFrame()
        {
            if (frame != null)
            {
                double.TryParse(comboBoxEscala.Text, out fatorDeEscala);
                int.TryParse(comboBoxMinViz.Text, out numeroMinimoDeVizinhos);
                int.TryParse(textBoxMinJanela.Text, out tamanhoDaJanela);

                if (tamanhoDaJanela < 1)
                {
                    tamanhoDaJanela = 1;
                    textBoxMinJanela.Text = tamanhoDaJanela.ToString();
                }

                imageBox1.Image = frameCinza;

                // detecta faces apartir da imagem em cinza e guarda elas em um array do tipo var
                var faces = frameCinza.DetectHaarCascade(haar, fatorDeEscala, numeroMinimoDeVizinhos, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(tamanhoDaJanela, tamanhoDaJanela))[0];
                if (faces.Length > 0)
                {
                    Bitmap bmpInput = frameCinza.ToBitmap();
                    Bitmap faceExtraida;
                    Graphics CanvasFace;

                    FacesExt = new Bitmap[faces.Length];
                    foreach (var face in faces)
                    {
                        frame.Draw(face.rect, new Bgr(Color.Green), 3);

                        faceExtraida = new Bitmap(face.rect.Width, face.rect.Height);

                        //coloca uma imagem vazia como canvas, para ser pintada
                        CanvasFace = Graphics.FromImage(faceExtraida);

                        CanvasFace.DrawImage(bmpInput, 0, 0, face.rect, GraphicsUnit.Pixel);

                        FacesExt[numFace] = faceExtraida;
                        numFace++;
                    }

                    numFace = 0;
                    pbFacesExtraidas.Image = FacesExt[numFace];

                }
                numFacesIdentificadas.Text = faces.Length.ToString();
            }
            imageBox1.Image = frame;
            frame = null;
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
                    Application.Idle -= carregarFrameCamera;
                    //imageBox1.Image = EmguCV ;
                }
                else
                {
                    //if camera is NOT getting frames then start the capture and set button
                    // Text to "Stop" for pausing capture
                    iniciarBT.Text = "Parar";
                    Application.Idle += carregarFrameCamera;
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
            Imagem.Save(Environment.CurrentDirectory + "\\" + nomeParaSalvar.Text + ".jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void nomeParaSalvar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeDaImagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPre_Click(object sender, EventArgs e)
        {
            if(numFace > 0)
                numFace--;
            pbFacesExtraidas.Image = FacesExt[numFace];
        }

        private void btPos_Click(object sender, EventArgs e)
        {
            if(numFace < FacesExt.Length)
                numFace++;
            pbFacesExtraidas.Image = FacesExt[numFace];
        }
    }
}
