public class Ruyviu : Fighter
{
    public Ruyviu(PointF initialPosition, int health) : base(initialPosition, health)
    {
        this.Image =  new Bitmap("./Assets/Sprites/Ruyviu.png");
        this.Name = "Ryu Ruivo";
    }

    protected override void setFrames()
    {
        setIdleFrames();
        setForwardFrames();
        setBackwardFrames();
        setJumpingFrames();
        setCrouchFrames();
        setLightPunchFrames();
        setMediumPunchFrames();
    }

    
    public override void DrawDebug(Graphics g)
    {
        base.DrawDebug(g);
        g.DrawString(
            $"Ruyviu: \n{this.Frame.HurtBox}\n{this.Position}",
            new Font("Arial",12),
            Brushes.Red,
            new PointF(40,80)
        );
    }

    #region Override SetFrames
    private void setForwardFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 1;

        for (int i = 0; i < 6; i++)
        {
            frames.Add( 
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(States.Forward, frames);
    }
    private void setBackwardFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 2;

        for (int i = 0; i < 6; i++)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.Backward,
            frames
        );
    }
    private void setIdleFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 0;

        for (int i = 0; i < 4; i++)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }
        for (int i = 3; i > 1; i--)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.Idle,
            frames
        );
    }
    private void setCrouchFrames()
    {
        setCrouchDownFrames();
        setCrouchUpFrames();

        List<Frame> frames = new List<Frame>();
        int row = 6 ;

        frames.Add(new Frame(
            new Point(360 + 200, 179 + (118 * row)),
            new Size(100, 118),
            new Point(0, 0)
        ));

        this.Frames.Add(
            States.Crouch,
            frames
        );
    }
    private void setCrouchUpFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 6;

        for (int i = 2; i > 0; i--)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.CrouchUp,
            frames
        );
    }
    private void setCrouchDownFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 6;

        for (int i = 0; i < 2; i++)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.CrouchDown,
            frames
        );
    }
    private void setJumpingFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 4;

        for (int i = 0; i < 5; i++)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.Jump,
            frames
        );

        this.setJumpingFFrames();
        this.setJumpingBFrames();
    }
    private void setJumpingFFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 7;

        for (int i = 0; i < 5 ; i++)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.JumpForward,
            frames
        );
    }
    private void setJumpingBFrames()
    {
        List<Frame> frames = new List<Frame>();
        int row = 7;

        for (int i = 4; i > 0 ; i--)
        {
            frames.Add(
                new Frame(
                    new Point(360 + (100 * i), 179 + (118 * row)),
                    new Size(100, 118),
                    new Point(0, 0)
                )
            );
        }

        this.Frames.Add(
            States.JumpBackward,
            frames
        );
    }
     private void setLightPunchFrames()
    {
        List<Frame> frames = new();
        int row = 3 ;
        int y = 179 + (118 * row);
        int height = 118;

        
        Frame frame = new Frame(
            new Point(360, y),
            new Size(80, height),
            new Point(30, Size.Height * 2)
        );
        frames.Add(frame);
        
        frame = new Frame(
            new Point(453, y),
            new Size(110, height),
            new Point(34, Size.Height * 2)
        );
        frames.Add(frame);
        
        
        Frames.Add(
            States.LightPunch,
            frames
        );
    }    
    private void setMediumPunchFrames()
    {
        List<Frame> frames = new();
        int row = 3 ;

        for (int i = 0; i < 2; i++)
        {
            Frame frame = new Frame(
                new Point(660 + (120 * i), 179 + (118 * row)),
                new Size(120, 118),
                new Point(0, 0)
            );
            frames.Add(frame);
        }
        
        Frames.Add(
            States.MediumPunch,
            frames
        );
    }    

    #endregion
}