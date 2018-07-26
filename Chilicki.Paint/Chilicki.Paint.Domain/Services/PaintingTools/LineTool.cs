﻿using System.Collections.Generic;
using Chilicki.Paint.Domain.ValueObjects.DrawingItems;
using Chilicki.Paint.Domain.ValueObjects;
using Chilicki.Paint.Common.Extensions.Lists;
using System.Windows.Media;

namespace Chilicki.Paint.Domain.Services.PaintingTools
{
    public class LineTool : IPainterTool
    {
        public IList<DrawingItem> Draw(IList<DrawingItem> drawingList, IList<Point> drawingPoints,
            DrawingItemProperties properties)
        {
            return Draw(drawingList, drawingPoints.First(), drawingPoints.Last(), properties);
        }

        private IList<DrawingItem> Draw(IList<DrawingItem> drawingList, Point drawingStartPoint, 
            Point drawingEndPoint, DrawingItemProperties properties)
        {
            drawingList.Add(new LineItem()
            {
                StartPointX = drawingStartPoint.X,
                StartPointY = drawingStartPoint.Y,
                EndPointX = drawingEndPoint.X,
                EndPointY = drawingEndPoint.Y,
                Thickness = properties.Thickness,
                Colour = new SolidColorBrush(properties.Colour),
            });
            return drawingList;
        }
    }
}
