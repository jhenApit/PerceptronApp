namespace Apit_Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        int input1, input2, numEpochs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            //get inputs from user
            input1 = Convert.ToInt32(tbIn1.Text);
            input2 = Convert.ToInt32(tbIn2.Text);
            numEpochs = Convert.ToInt32(tbEpoch.Text);

            //application of perceptron codes
            perceptron = new Perceptron(numInputs: 2);
            double[][] inputs = new double[][]
            {
                new double[] { 0, 0 },
                new double[] { 1, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 1 }
            };
            //set target
            int[] targets = new int[] { 1, 0, 0, 1 };

            //train perceptron
            perceptron.Train(inputs, targets, numEpochs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = perceptron.Activation(new double[] { input1, input2 }).ToString();
            
            lblOutput.Text = output;
        }
    }
}