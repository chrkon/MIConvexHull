﻿/******************************************************************************
 *
 * The MIT License (MIT)
 *
 * MIConvexHull, Copyright (c) 2015 David Sehnal, Matthew Campbell
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 *  
 *****************************************************************************/

namespace MIConvexHull
{
    /// <summary>
    /// An interface for a structure with nD position.
    /// </summary>
    public interface IVertex
    {
        /// <summary>
        /// Position of the vertex.
        /// </summary>
        /// <value>The position.</value>
        double[] Position { get; }
    }

    /// <summary>
    /// An interface for a structure with nD position.
    /// </summary>
    public interface IVertex2D
    {
        /// <summary>
        /// X coordinate value of the 2D vertex.
        double X { get; }

        /// <summary>
        /// Y coordinate value of the 2D vertex.
        double Y { get; }
    }

    /// <summary>
    /// "Default" vertex.
    /// </summary>
    /// <seealso cref="MIConvexHull.IVertex" />
    public class DefaultVertex : IVertex
    {
        /// <summary>
        /// Position of the vertex.
        /// </summary>
        /// <value>The position.</value>
        public double[] Position { get; set; }
    }
    /// <summary>
    /// "Default" vertex.
    /// </summary>
    /// <seealso cref="MIConvexHull.IVertex2D" />
    public class DefaultVertex2D : IVertex2D
    {
        public double X { get; set; }

        public double Y { get; set; }
    }
}