using Sansar.Simulation;
using Sansar.Script;
using Sansar;
using System.Collections.Generic;

namespace Examples {
  [DefaultScript]
  [DisplayName("Parameters")]
  class Parameters : SceneObjectScript
  {
    public string String;
    public int Integer;
    public float Float;
    [Range(0, 100)]
    public float Range;
    public bool Boolean;
    public Vector Vector;
    public Color Color;
    public ClusterResource Reference;
    public List<string> List;
    [DisplayName("-> Subscribe to event")]
    public string Subscribe;  
    [DisplayName("Trigger Event ->")]
    public string Trigger;
    public override void Init(){
    }
  }

  [DisplayName("Events")]
  class Events : SceneObjectScript
  {
    public override void Init(){
    }
  }
}