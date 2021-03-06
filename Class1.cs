    public class LineResearching
    {
        private Image currentFrame;
        protected byte[,] GetPixelMatrix()
        {
            return new byte[0, 0];
        }
        public virtual float GetAngle()
        {
            throw new Exception("Get angle fucntion wasn't overrided");
        }

        #region Utilities
        private static byte[] FromImageToArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private static byte[,] From1DArrayTo2DArray(byte[] input)
        {
            byte[,] result = new byte[320, 240];
            for (int i = 0; i < 240; i++)
            {
                for (int ii = 0; ii < 320; ii++)
                {
                    result[ii, i] = input[ii + i * 240];
                }
            }
            return result;
        }
        private static byte[] From2DArrayTo1DArray(byte[,] input)
        {
            byte[] result = new byte[320 * 240];
            for (int i = 0; i < 240; i++)
            {
                for (int ii = 0; ii < 320; ii++)
                {
                    result[ii * 320 + i] = input[i, ii];
                }
            }
            return result;
        }
        private static Image FromArrayToImage(byte[] input)
        {
            return (Bitmap)((new ImageConverter()).ConvertFrom(input));
        }
        #endregion
    }
    public class FourSideAlgorithm : LineResearching
    {
        public override float GetAngle()
        {
            float f = 0;
            return f;
        }
    }
