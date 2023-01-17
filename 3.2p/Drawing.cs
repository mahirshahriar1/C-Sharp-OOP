using SplashKitSDK;
using System.Collections;
using System.Collections.Generic;

namespace project
{
    public class Drawing
    {
        private List<Shape> _shapes;
        private Color _background;


        public Drawing() : this(Color.White)
        {
            // other steps could go here…
        }
        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }
        public int ShapeCount
        {
            get { return _shapes.Count; }  
        }
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }


        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            
            foreach (Shape shape in _shapes)
            {
                shape.Draw();
               // Console.WriteLine("draw");
            }
           
        }

        public void SelectedShapeAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }

                //if(s.IsAt(pt)){ if(!s.Selected) s.Selected = true; }
            }
        }

        public List<Shape> SelectedShapes()
        {
            List<Shape> _selectedShapes = new List<Shape>();
            foreach (Shape s in _shapes)
            {
           
                if (s.Selected)
                {                    
                    _selectedShapes.Add(s);
                }
            }
            return _selectedShapes;
        }
        public void deleteAll()
        {
            List<Shape> selected_shapes_list = SelectedShapes();
            
            for (int i = 0; i < selected_shapes_list.Count(); i++)
            {
                if (selected_shapes_list.Contains(selected_shapes_list[i]))
                {
                    _shapes.Remove(selected_shapes_list[i]);
                }
            }
        }

        public void RemoveShape()
        {
            //List<Shape> toRemove = new List<Shape>();
            //foreach (Shape s in _shapes)
            //{                
            //    if (s.Selected)
            //    {
            //        toRemove.Add(s);
            //    }
            //}

            //_shapes.RemoveAll(x => toRemove.Contains(x));

            for (int i = 0; i < _shapes.Count(); i++)
            {
                if (_shapes[i].Selected)
                {
                    _shapes.Remove(_shapes[i]);//
                    i--;//
                    //break;
                }
            }

            //foreach(Shape S in _shapes.ToList())
            //{
            //    if (S.Selected)
            //    {
            //        _shapes.Remove(S);
            //    }
            //}


        }



    }
}