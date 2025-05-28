using System.Collections.ObjectModel;
using ReactiveUI;

namespace Chess_Prototype.ViewModels;

public class ChessBoardViewModel : ReactiveObject
{
    public ObservableCollection<SquareViewModel> Squares { get; }

    public ChessBoardViewModel()
    {
        Squares = new ObservableCollection<SquareViewModel>();
        
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Squares.Add(new SquareViewModel
                {
                    Row = row,
                    Column = col,
                    IsLight = (row + col) % 2 == 0
                });
            }
        }
    }
    
}

public class SquareViewModel
{
    public int Row { get; set; }
    public int Column { get; set; }
    public bool IsLight { get; set; } // For alternating color
}