public class Frame
{
    public Size Size { get; set; }
    public Point PointInSpriteSheet { get; set; }
    public Point OriginPoint { get; set; }
    public Frame(Point pointInSpriteSheet, Size size, Point originPoint)
    {
        PointInSpriteSheet = pointInSpriteSheet;
        Size = size;
        if (originPoint.X != 0 && originPoint.Y != 0)
            OriginPoint = originPoint;
        else
            OriginPoint = new Point((int)(size.Width * 1.5), (int)(size.Height * 2.8));
    }

    public Rectangle ToRectangle()
        => new Rectangle(PointInSpriteSheet, Size);
}