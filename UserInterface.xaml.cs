using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VMS.TPS.Common.Model.API;

namespace RescaleOptimizationObjectives
{
    /// <summary>
    /// Interaction logic for UserInterface.xaml
    /// </summary>
    public partial class UserInterface : UserControl
    {
        private PlanSetup _planSetup;

        public UserInterface(PlanSetup planSetup)
        {
            InitializeComponent();
            _planSetup = planSetup;
            LoadCurrentDoseFractionation();
        }

        private void LoadCurrentDoseFractionation()
        {
            currentDosePerFractionTextBlock.Text = _planSetup.DosePerFraction.ValueAsString;
            currentNumberOfFractionsTextBlock.Text = _planSetup.NumberOfFractions.ToString();
            currentTotalDoseTextBlock.Text = _planSetup.TotalDose.ValueAsString;
        }
    }
}
