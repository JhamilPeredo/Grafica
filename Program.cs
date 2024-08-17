using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace ConsoleApp1
{
    class Program : GameWindow
    {
        static void Main(string[] args)
         {
             using (Program program = new Program(500, 700, "T en 3D"))
             {
                 program.Run(); 
             }
         }

         public Program(int width, int height, string title)
             : base(width, height, GraphicsMode.Default, title)
         {
         }

         protected override void OnLoad(EventArgs e)
         {
             base.OnLoad(e);
          

             GL.Color3(0.0f, 1.0f, 0.0f);
             GL.Enable(EnableCap.DepthTest);

            
             GL.MatrixMode(MatrixMode.Projection);
             GL.LoadIdentity();
             Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 0.1f, 100.0f);
             GL.LoadMatrix(ref projection);

             
             GL.MatrixMode(MatrixMode.Modelview);
             GL.LoadIdentity();

            
             GL.Translate(0.0f, 0.5f, -10.0f); 
             GL.Rotate(20.0f, 1.0f, 0.0f, 0.0f); 
             GL.Rotate(20.0f, 0.0f, 1.0f, 0.0f); 
         }

         protected override void OnRenderFrame(FrameEventArgs e)
         {
             base.OnRenderFrame(e);

             GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

             GL.MatrixMode(MatrixMode.Modelview);
             GL.LoadIdentity();

          
             GL.Translate(0.0f, 0.5f, -10.0f); 
             GL.Rotate(20.0f, 1.0f, 0.0, 0.0f); 
             GL.Rotate(20.0f, 0.0f, 1.0f, 0.0f); 

             DrawT();

             SwapBuffers();
         }

         private void DrawT()
         {
             GL.Color3(0.0f, 1.0f, 0.0f); 

             
             GL.Begin(PrimitiveType.Lines);

           
             GL.Vertex3(-1.0f, 0.5f, 0.5f);
             GL.Vertex3(1.0f, 0.5f, 0.5f);
             GL.Vertex3(1.0f, 0.5f, 0.5f);
             GL.Vertex3(1.0f, 0.0f, 0.5f);
             GL.Vertex3(1.0f, 0.0f, 0.5f);
             GL.Vertex3(-1.0f, 0.0f, 0.5f);
             GL.Vertex3(-1.0f, 0.0f, 0.5f);
             GL.Vertex3(-1.0f, 0.5f, 0.5f);

             
             GL.Vertex3(-1.0f, 0.5f, -0.5f);
             GL.Vertex3(1.0f, 0.5f, -0.5f);
             GL.Vertex3(1.0f, 0.5f, -0.5f);
             GL.Vertex3(1.0f, 0.0f, -0.5f);
             GL.Vertex3(1.0f, 0.0f, -0.5f);
             GL.Vertex3(-1.0f, 0.0f, -0.5f);
             GL.Vertex3(-1.0f, 0.0f, -0.5f);
             GL.Vertex3(-1.0f, 0.5f, -0.5f);

             
             GL.Vertex3(-1.0f, 0.5f, 0.5f);
             GL.Vertex3(-1.0f, 0.5f, -0.5f);
             GL.Vertex3(1.0f, 0.5f, 0.5f);
             GL.Vertex3(1.0f, 0.5f, -0.5f);
             GL.Vertex3(1.0f, 0.0f, 0.5f);
             GL.Vertex3(1.0f, 0.0f, -0.5f);
             GL.Vertex3(-1.0f, 0.0f, 0.5f);
             GL.Vertex3(-1.0f, 0.0f, -0.5f);

             GL.End();

          
             GL.Begin(PrimitiveType.Lines);

            
             GL.Vertex3(-0.25f, 0.0f, 0.5f);
             GL.Vertex3(0.25f, 0.0f, 0.5f);
             GL.Vertex3(0.25f, 0.0f, 0.5f);
             GL.Vertex3(0.25f, -1.0f, 0.5f);
             GL.Vertex3(0.25f, -1.0f, 0.5f);
             GL.Vertex3(-0.25f, -1.0f, 0.5f);
             GL.Vertex3(-0.25f, -1.0f, 0.5f);
             GL.Vertex3(-0.25f, 0.0f, 0.5f);

             
             GL.Vertex3(-0.25f, 0.0f, -0.5f);
             GL.Vertex3(0.25f, 0.0f, -0.5f);
             GL.Vertex3(0.25f, 0.0f, -0.5f);
             GL.Vertex3(0.25f, -1.0f, -0.5f);
             GL.Vertex3(0.25f, -1.0f, -0.5f);
             GL.Vertex3(-0.25f, -1.0f, -0.5f);
             GL.Vertex3(-0.25f, -1.0f, -0.5f);
             GL.Vertex3(-0.25f, 0.0f, -0.5f);

             
             GL.Vertex3(-0.25f, 0.0f, 0.5f);
             GL.Vertex3(-0.25f, 0.0f, -0.5f);
             GL.Vertex3(0.25f, 0.0f, 0.5f);
             GL.Vertex3(0.25f, 0.0f, -0.5f);
             GL.Vertex3(0.25f, -1.0f, 0.5f);
             GL.Vertex3(0.25f, -1.0f, -0.5f);
             GL.Vertex3(-0.25f, -1.0f, 0.5f);
             GL.Vertex3(-0.25f, -1.0f, -0.5f);

             GL.End();
         }
    }  
}

