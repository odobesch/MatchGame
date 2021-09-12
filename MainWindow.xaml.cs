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

namespace MatchGame {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            
            SetUpGame();
                
            }

        private void SetUpGame() {
            // Create list of 8 pairs of emoji
            List<string> animalEmoji = new List<string>() {
                "🦑", "🦑",
                "🐟","🐟",
                "🐘","🐘",
                "🐳","🐳",
                "🐪","🐪",
                "🦕","🦕",
                "🦘","🦘",
                "🦔","🦔",
                }
                ;
            Random random = new Random();                                                                       // Create new random number generator
            foreach  (TextBlock item in mainGrid.Children.OfType<TextBlock>()) {                                // Find every textblock in the mainGrid and repeat the statements
                int index = random.Next(animalEmoji.Count);                                                     // Random number from 0 to count of emojis left in the list
                string nextEmoji = animalEmoji[index];                                                          // use random called index to get random emoji from list
                item.Text = nextEmoji;                                                                          // Update TextBlock with random emoji from list
                animalEmoji.RemoveAt(index);                                                                    // remove random emoji from list
                }

            }
        }
    }
