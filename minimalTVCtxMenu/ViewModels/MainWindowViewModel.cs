using System;
using System.Collections.ObjectModel;

namespace minimalTVCtxMenu.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    
    public ObservableCollection<Node> Items { get; set; }

    public MainWindowViewModel()
    {
        var n1 = new Node("n1");
        n1.Add("n11");
        n1.Add("n12");
        n1.Add("n13");
        
        var n2 = new Node("n2");
        n2.Add("n21");
        n2.Add("n22");
        n2.Add("n23");

        var n0 = new Node("n0");
        n0.Add(n1);
        n0.Add(n2);

        Items = new ObservableCollection<Node>();
        Items.Add(n0);
    }

    
}