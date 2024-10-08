// Include code libraries you need below (use the namespace).
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;


namespace Game10003
{

    public class Game
    {
        // Variables:

        float MouseX;
        float MouseY;

        Color[] colors = new Color[] {Random.Color(), Random.Color(), Random.Color(), Random.Color()};

        Vector2[] Squares = new Vector2[] {new Vector2(0,0), new Vector2(0,300), new Vector2(300,0), new Vector2(300,300)};

        public void Setup()
        {
            Window.SetTitle("silly lil' art piece");
            Window.SetSize(600, 600);
        }

        public void Update()
        {
            // Generates new random colors on each mouse click
            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                colors = new Color[] { Random.Color(), Random.Color(), Random.Color(), Random.Color() };
            }

            MouseX = Input.GetMouseX();
            MouseY = Input.GetMouseY();
          
            Draw.FillColor = Color.Gray;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 3;

            // Draws the grid
            foreach (var square in Squares)
            {
                Draw.Square(square, 300);
            }

            // Top left square
            if (MouseX >= 0 & MouseX <= 300 & MouseY >= 0 & MouseY <= 300 & Input.IsMouseButtonDown(MouseInput.Left))
            {                              
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[0];

                Draw.Square(Squares[0], 300);
            }

            // Top right square
            else if (MouseX >= 300 & MouseX <= 600 & MouseY >= 0 & MouseY <= 300 & Input.IsMouseButtonDown(MouseInput.Left))
            {            
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[1];

                Draw.Square(Squares[2], 300);
            }

            // Bottom left square
            else if (MouseX >= 0 & MouseX <= 300 & MouseY >= 300 & MouseY <= 600 & Input.IsMouseButtonDown(MouseInput.Left))
            {              
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[2];

                Draw.Square(Squares[1], 300);
            }

            // Bottom right square
            else if (MouseX >= 300 & MouseX <= 600 & MouseY >= 300 & MouseY <= 600 & Input.IsMouseButtonDown(MouseInput.Left))
            {            
                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.FillColor = colors[3];

                Draw.Square(Squares[3], 300);
            }


        }
    }
}
