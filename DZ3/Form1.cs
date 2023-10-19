namespace DZ3
{
    public partial class Form1 : Form
    {
        private Thread _primeThread;
        private Thread _fibonacciThread;

        private CancellationTokenSource _primeCancellationTokenSource;
        private CancellationTokenSource _fibonacciCancellationTokenSource;
        private CancellationToken _primeToken;
        private CancellationToken _fibonacciToken;

        private int _primeUpperBound;
        private int _primeCurrentValue;
        private int _fibonacciUpperBound;
        private int _fibonacciCurrentValue;
        public Form1()
        {
            InitializeComponent();
            numericUpDownStart.Minimum = 2;
            numericUpDownEnd.Minimum = 2;
            numericUpDownStart.Maximum = int.MaxValue;
            numericUpDownEnd.Maximum = int.MaxValue;

            _primeCancellationTokenSource = new CancellationTokenSource();
            _primeToken = _primeCancellationTokenSource.Token;
            _fibonacciCancellationTokenSource = new CancellationTokenSource();
            _fibonacciToken = _fibonacciCancellationTokenSource.Token;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (numericUpDownEnd.Value < numericUpDownStart.Value)
            {
                MessageBox.Show("Wrong bounds");
                return;
            }
            Button clicked = (Button)sender;
            if (clicked.Tag.ToString() == "S")
            {
                listBoxSimple.Items.Clear();
                _primeThread = new Thread(generatePrime);
                _primeThread.Start(new int[] { (int)numericUpDownStart.Value, (int)numericUpDownEnd.Value });
                _primeUpperBound = (int)numericUpDownEnd.Value;
                buttonShutSimple.Enabled = true;
                buttonStopSimple.Enabled = true;
            }
            else
            {
                listBoxFibonacci.Items.Clear();
                _fibonacciThread = new Thread(generateFibonacci);
                _fibonacciThread.Start(new int[] { (int)numericUpDownStart.Value, (int)numericUpDownEnd.Value });
                _fibonacciUpperBound = (int)numericUpDownEnd.Value;
                buttonShutFibonacci.Enabled = true;
                buttonStopFibonacci.Enabled = true;
            }
        }

        private void buttonShut_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (clicked.Tag.ToString() == "S")
            {
                _primeCancellationTokenSource.Cancel();
                buttonStartSimple.Enabled = true;
                buttonStopSimple.Enabled = false;
                buttonShutSimple.Enabled = false;
                buttonContinueSimple.Enabled = false;
            }
            else
            {
                _fibonacciCancellationTokenSource.Cancel();
                buttonStartFibonacci.Enabled = true;
                buttonStopFibonacci.Enabled = false;
                buttonShutFibonacci.Enabled = false;
                buttonContinueFibonacci.Enabled = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (clicked.Tag.ToString() == "S")
            {
                _primeCancellationTokenSource.Cancel();
                buttonStartSimple.Enabled = true;
                buttonStopSimple.Enabled = false;
                buttonShutSimple.Enabled = false;
                buttonContinueSimple.Enabled = true;
            }
            else
            {
                _fibonacciCancellationTokenSource.Cancel();
                buttonStartFibonacci.Enabled = true;
                buttonStopFibonacci.Enabled = false;
                buttonShutFibonacci.Enabled = false;
                buttonContinueFibonacci.Enabled = true;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (clicked.Tag.ToString() == "S")
            {
                _primeThread = new Thread(generatePrime);
                _primeThread.Start(new int[] { _primeCurrentValue, _primeUpperBound });
                _primeUpperBound = (int)numericUpDownEnd.Value;
                buttonShutSimple.Enabled = true;
                buttonStopSimple.Enabled = true;
            }
            else
            {
                _fibonacciThread = new Thread(generateFibonacci);
                _fibonacciThread.Start(new int[] { _fibonacciCurrentValue, _fibonacciUpperBound });
                _fibonacciUpperBound = (int)numericUpDownEnd.Value;
                buttonShutFibonacci.Enabled = true;
                buttonStopFibonacci.Enabled = true;
            }
        }

        private void generatePrime(object bounds)
        {
            int[] stEnd = (int[])(bounds);
            for (int i = stEnd[0]; i <= stEnd[1]; i++)
            {
                _primeCurrentValue = i;
                Thread.Sleep(50);
                if (_primeToken.IsCancellationRequested)
                {
                    _primeCancellationTokenSource = new CancellationTokenSource();
                    _primeToken = _primeCancellationTokenSource.Token;
                    return;
                }
                if (isPrime(i))
                {
                    listBoxSimple.Invoke(() => { listBoxSimple.Items.Add(i.ToString()); });
                }
            }
            buttonShutSimple.Invoke(() => { buttonShutSimple.Enabled = false; });
            buttonStopSimple.Invoke(() => { buttonStopSimple.Enabled = false; });
            buttonContinueSimple.Invoke(() => { buttonContinueSimple.Enabled = false; });
        }

        private void generateFibonacci(object bounds)
        {
            int[] stEnd = (int[])(bounds);
            for (int i = stEnd[0]; i <= stEnd[1]; i++)
            {
                _fibonacciCurrentValue = i;
                Thread.Sleep(100);
                if (_fibonacciToken.IsCancellationRequested)
                {
                    _fibonacciCancellationTokenSource = new CancellationTokenSource();
                    _fibonacciToken = _fibonacciCancellationTokenSource.Token;
                    return;
                }
                if (IsFibonacci(i))
                {
                    listBoxFibonacci.Invoke(() => { listBoxFibonacci.Items.Add(i.ToString()); });
                }
            }
            buttonShutFibonacci.Invoke(() => { buttonShutFibonacci.Enabled = false; });
            buttonStopFibonacci.Invoke(() => { buttonStopFibonacci.Enabled = false; });
            buttonContinueFibonacci.Invoke(() => { buttonContinueFibonacci.Enabled = false; });
        }

        private bool isPrime(int num)
        {
            if (num < 0)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        private bool IsFibonacci(int num)
        {
            if (num < 0)
            {
                return false;
            }

            int a = 0;
            int b = 1;
            int temp;

            while (a < num)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            return a == num;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _primeCancellationTokenSource.Cancel();
            _fibonacciCancellationTokenSource.Cancel();
        }
    }
}