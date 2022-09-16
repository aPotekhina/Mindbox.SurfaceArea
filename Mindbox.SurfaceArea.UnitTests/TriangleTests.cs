using System;
using Mindbox.SurfaceArea.Core.Triangle;
using Xunit;

namespace Mindbox.SurfaceArea.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_SurfaceAreaCalculation_Success()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            const double expectedSurfaceArea = 3 * 4 * 0.5;

            // Act
            var surfaceArea = triangle.CalculateSurfaceArea();

            // Assert
            Assert.Equal(expectedSurfaceArea, surfaceArea);
        }
        
        [Fact]
        public void Triangle_Constructor_NegativeSide_ExceptionThrown()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 5));
        }

        [Fact]
        public void Triangle_RightTriangleCheck_RightTriangle_Success()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            const bool expectedRightTriangleCheck = true;

            // Act
            var rightTriangleCheck = triangle.RightTriangleCheck();

            // Assert
            Assert.Equal(expectedRightTriangleCheck, rightTriangleCheck);
        }
        
        [Fact]
        public void Triangle_RightTriangleCheck_NotARightTriangle_Success()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);
            const bool expectedRightTriangleCheck = false;

            // Act
            var rightTriangleCheck = triangle.RightTriangleCheck();

            // Assert
            Assert.Equal(expectedRightTriangleCheck, rightTriangleCheck);
        }
        
        [Fact]
        public void Triangle_SideSetter_Success()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            const double expectedSide = 6;

            // Act
            triangle.SideC = expectedSide;

            // Assert
            Assert.Equal(expectedSide, triangle.SideC);
        }
        
        [Fact]
        public void Triangle_SideSetter_NegativeSide_ExceptionThrown()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => { triangle.SideC = -1; });
        }
    }
}