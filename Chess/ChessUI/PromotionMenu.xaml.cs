using System.Windows.Controls;
using System.Windows.Input;
using ChessLogic;

namespace ChessUI
{
    /// <summary>
    /// Interaction logic for PromotionMenu.xaml
    /// </summary>
    public partial class PromotionMenu : UserControl
    {
        public event Action<PieceType> pieceSelected;


        public PromotionMenu(Player player)
        {
            InitializeComponent();

            QueenImg.Source = Images.GetImage(player, PieceType.Queen);
            BishopImg.Source = Images.GetImage(player, PieceType.Bishop);
            RookImg.Source = Images.GetImage(player, PieceType.Rook);
            KnightImg.Source = Images.GetImage(player, PieceType.Knight);
        }

        private void QueenImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pieceSelected?.Invoke(PieceType.Queen);
        }

        private void BishopImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pieceSelected?.Invoke(PieceType.Bishop);
        }

        private void RookImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pieceSelected?.Invoke(PieceType.Rook);
        }

        private void KnightImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pieceSelected?.Invoke(PieceType.Knight);
        }
    }
}
