using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DynamicData;

namespace minimalTVCtxMenu;

public class Node
{
    public ObservableCollection<Node> Items { get; set; }
    
    public string Label { get; set; }


    public Node(string label) : this(label, new List<Node>())
    {
        
    }
    
    public Node(string label, IList<Node> nodes)
    {
        Label = label;
        Items = new ObservableCollection<Node>();
        if (nodes != null)
        {
            Items.AddRange(nodes);
        }
    }
    public void Add(string label)
    {
        Items.Add(new Node(label, new List<Node>()));
    }

    public void Add(Node node)
    {
        Items.Add(node);
    }
    
    public void Say(Node node)
    {
        Console.WriteLine(node.Label);
    }
    
}