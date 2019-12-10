using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAPIs_Kernel32
{
    public partial class Form1 : Form
    {
        //To get system information
        [DllImport("kernel32")]
        static extern void GetSystemInfo(ref SYSTEM_INFO pSI);

        //To get Memory status
        [DllImport("kernel32")]
        static extern void GlobalMemoryStatus(ref MEMORYSTATUS buf);


        //Cnstants used for processor types
        public const int PROCESSOR_INTEL_386 = 386;
        public const int PROCESSOR_INTEL_486 = 486;
        public const int PROCESSOR_INTEL_PENTIUM = 586;
        public const int PROCESSOR_MIPS_R4000 = 4000;
        public const int PROCESSOR_ALPHA_21064 = 21064;

        public Form1()
        {
            InitializeComponent();
        }
        protected void button1_Click(object sender, System.EventArgs e)
        {

            try
            {
                SYSTEM_INFO pSI = new SYSTEM_INFO();
                GetSystemInfo(ref pSI);
                string CPUType = "(unknown)"; ;
                switch (pSI.dwProcessorType)
                {

                    case PROCESSOR_INTEL_386:
                        CPUType = "Intel 386";
                        break;
                    case PROCESSOR_INTEL_486:
                        CPUType = "Intel 486";
                        break;
                    case PROCESSOR_INTEL_PENTIUM:
                        CPUType = "Intel Pentium";
                        break;
                    case PROCESSOR_MIPS_R4000:
                        CPUType = "MIPS R4000";
                        break;
                    case PROCESSOR_ALPHA_21064:
                        CPUType = "DEC Alpha 21064";
                        break;
                  
                }

                listBox1.Items.Add("Active Processor Mask :		" + pSI.dwActiveProcessorMask.ToString());
                listBox1.Items.Add("Allocation Granularity :		" + pSI.dwAllocationGranularity.ToString());
                listBox1.Items.Add("Number Of Processors :		" + pSI.dwNumberOfProcessors.ToString());
                listBox1.Items.Add("OEM ID :				" + pSI.dwOemId.ToString());
                listBox1.Items.Add("Page Size :			" + pSI.dwPageSize.ToString());
                // Processor Level (Req filtering to get level)
                listBox1.Items.Add("Processor Level Value :		" + pSI.dwProcessorLevel.ToString());
                listBox1.Items.Add("Processor Revision :		" + pSI.dwProcessorRevision.ToString());
                listBox1.Items.Add("CPU type :			" + CPUType);
                listBox1.Items.Add("Maximum Application Address :	" + pSI.lpMaximumApplicationAddress.ToString());
                listBox1.Items.Add("Minimum Application Address :	" + pSI.lpMinimumApplicationAddress.ToString());

                /**************	To retrive info from GlobalMemoryStatus ****************/

                MEMORYSTATUS memSt = new MEMORYSTATUS();
                GlobalMemoryStatus(ref memSt);

                listBox1.Items.Add("Available Page File :		" + (memSt.dwAvailPageFile / 1024).ToString());
                listBox1.Items.Add("Available Physical Memory :		" + (memSt.dwAvailPhys / 1024).ToString());
                listBox1.Items.Add("Available Virtual Memory :		" + (memSt.dwAvailVirtual / 1024).ToString());
                listBox1.Items.Add("Size of structur :			" + memSt.dwLength.ToString());
                listBox1.Items.Add("Memory In Use :			" + memSt.dwMemoryLoad.ToString());
                listBox1.Items.Add("Total Page Size :			" + (memSt.dwTotalPageFile / 1024).ToString());
                listBox1.Items.Add("Total Physical Memory :		" + (memSt.dwTotalPhys / 1024).ToString());
                listBox1.Items.Add("Total Virtual Memory :		" + (memSt.dwTotalVirtual / 1024).ToString());

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
