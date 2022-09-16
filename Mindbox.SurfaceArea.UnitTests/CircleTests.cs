using System;
using Mindbox.SurfaceArea.Core.Circle;
using Xunit;

namespace Mindbox.SurfaceArea.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void  Circle_SurfaceAreaCalculation_Success()
        {
            // Arrange
            var circle = new Circle(3);
            const double expectedSurfaceArea = 3 * 3 * Math.PI;

            // Act
            var surfaceArea = circle.CalculateSurfaceArea();

            // Assert
            Assert.Equal(expectedSurfaceArea, surfaceArea);
        }
        
        [Fact]
        public void Circle_Constructor_NegativeRadius_ExceptionThrown()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(-3));
        }

        [Fact]
        public void Circle_RadiusSetter_Success()
        {
            // Arrange
            var circle = new Circle(3);
            const double expectedRadius = 4;

            // Act
            circle.Radius = expectedRadius;

            // Assert
            Assert.Equal(expectedRadius, circle.Radius);
        }
        
        [Fact]
        public void Circle_RadiusSetter_NegativeRadius_ExceptionThrown()
        {
            // Arrange
            var circle = new Circle(3);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => { circle.Radius = -1; });
        }
    }
}