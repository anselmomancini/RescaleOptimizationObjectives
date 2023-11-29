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
            LoadStructuresWithOptimizationObjective();
        }

        private void LoadCurrentDoseFractionation()
        {
            currentDosePerFractionTextBlock.Text = _planSetup.DosePerFraction.ValueAsString;
            currentNumberOfFractionsTextBlock.Text = _planSetup.NumberOfFractions.ToString();
            currentTotalDoseTextBlock.Text = _planSetup.TotalDose.ValueAsString;
        }

        private void LoadStructuresWithOptimizationObjective()
        {
            foreach (var structureId in _planSetup.OptimizationSetup.Objectives.Select(x => x.StructureId).Distinct())
            {
                TextBlock structureIdTextBlock = new TextBlock
                {
                    Text = structureId
                };

                TextBox factorTextBox = new TextBox
                {
                    Width = 40,
                    Margin = new Thickness(5, 0, 0, 0)
                };

                StackPanel stackPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    Margin = new Thickness(0, 0, 0, 5)
                };

                stackPanel.Children.Add(structureIdTextBlock);
                stackPanel.Children.Add(factorTextBox);

                mainStackPanel.Children.Add(stackPanel);
            }
        }

        private void newFractionationTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // validação básica para permitir que o usuário preencha os 2 campos, caso contrário, haverá crash
            if (uint.TryParse(newDosePerFractionTextBox.Text, out var newDosePerFraction) && uint.TryParse(newNumberOfFractionsTextBox.Text, out var newNumberOfFractions))
            {
                newTotalDoseTextBlock.Text = (newDosePerFraction * newNumberOfFractions).ToString();

                double globalFactor = double.Parse(newTotalDoseTextBlock.Text) / double.Parse(currentTotalDoseTextBlock.Text);

                // preenche cada estrutura com o valor global
                foreach (StackPanel stack in mainStackPanel.Children)
                {
                    foreach (TextBox textBox in stack.Children.OfType<TextBox>())
                        textBox.Text = globalFactor.ToString("F2");
                }

                startButton.IsEnabled = true;
            }
            else
                startButton.IsEnabled = false;
        }
    }
}
