//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Drawing;
//using System.Runtime.InteropServices;
//using Emgu.CV;
//using Emgu.CV.CvEnum;
//using Emgu.CV.Features2D;
//using Emgu.CV.Structure;
//using Emgu.CV.Util;
//#if !__IOS__
//using Emgu.CV.Cuda;
//#endif
//using Emgu.CV.XFeatures2D;

//namespace OpenCVTest
//{
//    public static class Class1
//    {
//        public static void FindMatch(Mat modelImage, Mat observedImage, out long matchTime,out VectorOfKeyPoint modelKeyPoints, out VectorOfKeyPoint observedKeyPoints, VectorOfVectorOfDMatch matches,out Mat mask, out Mat homograpghy)
//        {
//            int k = 2;
//            double uniquenessThreshold = 0.8;
//            double hessianThresh = 300;

//            Stopwatch watch;
//            homograpghy = null;

//            modelKeyPoints = new VectorOfKeyPoint();
//            observedKeyPoints = new VectorOfKeyPoint();

//            #if !__IOS__

//            if(CudaInvoke.HasCuda)
//            {
//                CudaSURF surfCuda=new CudaSURF(float)( hessianThresh );
//                using(GpuMat gpuModelImage=new GpuMat(modelImage))

//                //extract features from the observed image

//                using(GpuMat gpuObservedImage=new GpuMat(observedImage))
//                using(GpuMat gpuObservedKeyPoints=surfCuda.DetectKeyPointsRaw(gpuObservedImage,null))
//                using(GpuMat gpuObservedDescriptors=surfCuda.ComputeDescriptorsRaw(gpuObservedImage,null,gpuObservedKeyPoints))

//                using(GpuMat tmp=new GpuMat())
//                using(Stream stream=new Stream())

//                {
//                    surfCuda.DownloadKeypoints(gpuObservedKeyPoints,observedKeyPoints);
//                    mask=new Mat(matches.Size,1,DepthType.Cv8U,1);
//                    mask.SetTo(new MCvScalar(255));

//                    Features2DToolbox.VoteForUniqueness(matches,uniquenessThreshold,mask);

//                    int nonZeroCount=CvInvoke.CountNonZero(mask);

//                    if(nonZeroCount >= 4)
//                    {
//                        nonZeroCount=Features2DToolbox.VoteForSizeAndOrientation(modelKeyPoints,observedKeyPoints,matches,mask,1.5,20);


//                        if(nonZeroCount >= 4)
//                            homograpghy=Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelKeyPoints,observedKeyPoints,matches,mask,2);

//                    }


                        
//                }

//                //watch.Stop();
                

//            }

//        }
//    }
//}
//        else
//       #endif
//    {
//        SURF surfCPU=new SURF(hessianThresh);

//        //extract features from the observed image

//        UMat modelDescriptor=new UMat();
//        SURFCPU.DetectAndCompute(uObservedImage,null,observedKeyPoints,observedDescriptors,false);
//        BFMatcher matcher=new BFMatcher(DistanceType.L2);
//        BFMatcher.Add(modelDescriptors);

//        BFMatcher.KnnMatch(observedDescriptors,matches,k,null);
//        mask=new Mat(matches.Size,1,DepthType.Cv8U,1);
//        Mask.SetTo(new MCvScalar(255));

//        Features2DToolbox.VoteForUniqueness(matches,uniquenessThreshold,mask);


//        int nonZeroCount=CvInvoke.CountNonZero(mask);

//        if(nonZeroCount >= 4)
//    {

//    }

//    }

//    }
//}
