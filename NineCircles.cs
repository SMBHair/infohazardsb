using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class NineCircles : StoryboardObjectGenerator
    {
        [Group("Settings")]
        [Description("n side length")]
        [Configurable] public int GridSize;

        public override void Generate()
        {
		    var layer = GetLayer("");
            // var box = layer.CreateSprite("sb/black.png", OsbOrigin.Centre, new Vector2(640+89, 0));
            // box.Scale(128275, 0.5);
            // box.Fade(128275, 140000, 1, 1);

            OsbSprite[,] box = new OsbSprite[GridSize, GridSize];


            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    int x = -100 + (1000/GridSize)*i;
                    int y = -200 + (1000/GridSize)*j;
                    box[i,j] = layer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(x, y));
                    box[i,j].Scale(128275, 140000, 5f/GridSize, 5f/GridSize);

                    // box[i,j].StartLoopGroup(127448, 32);
                    // box[i,j].Fade((40+i-j)%4*103.448, (40+i-j)%4*103.448 + 103.448*8, 1, 0);
                    // box[i,j].EndGroup();

                    for (int t = 0; t < 16; t++)
                    {
                        double st = 127448;
                        if (t%4==0)
                        {
                            st = 127448 + t*103.448*16 + (40+i-j)%4*103.448;
                            box[i,j].ColorHsb(st, 0, 1, 1);
                        }
                        if (t%4==1)
                        {
                            st = 127448 + t*103.448*16 + (40+i+j)%4*103.448;
                            box[i,j].ColorHsb(st, 10, 1, 1);
                        }
                        if (t%4==2)
                        {
                            st = 127448 + t*103.448*16 + (40-i+j)%4*103.448;
                            box[i,j].ColorHsb(st, 20, 1, 1);
                        }
                        if (t%4==3)
                        {
                            st = 127448 + t*103.448*16 + (40-i-j)%4*103.448;
                            box[i,j].ColorHsb(st, 30, 1, 1);
                        }
                        box[i,j].Fade(st, st + 103.448*8, 0.7, 0);
                        box[i,j].Fade(st + 103.448*8, st + 103.448*16, 0.7, 0);
                        box[i,j].Additive(127448, 153931);
                    }
                }
            }

            // the flicker.
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    int x = -100 + (1000/GridSize)*i;
                    int y = -200 + (1000/GridSize)*j;
                    box[i,j] = layer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(x, y));
                    box[i,j].Scale(159724, 160551, 5f/GridSize, 5f/GridSize);

                    for (int t = 0; t < 1; t++)
                    {
                        double st = 159724;
                        if (t%4==0)
                        {
                            st = 159724 + t*103.448*16 + (40+i-j)%4*103.448;
                            box[i,j].ColorHsb(st, 0, 1, 1);
                        }
                        if (t%4==1)
                        {
                            st = 159724 + t*103.448*16 + (40+i+j)%4*103.448;
                            box[i,j].ColorHsb(st, 10, 1, 1);
                        }
                        if (t%4==2)
                        {
                            st = 159724 + t*103.448*16 + (40-i+j)%4*103.448;
                            box[i,j].ColorHsb(st, 20, 1, 1);
                        }
                        if (t%4==3)
                        {
                            st = 159724 + t*103.448*16 + (40-i-j)%4*103.448;
                            box[i,j].ColorHsb(st, 30, 1, 1);
                        }
                        box[i,j].Fade(st, st + 103.448*8, 0.7, 0);
                        box[i,j].Additive(159724, 160551);
                    }
                }
            }


            // i gave up on rotating ts
            // for (int i = 0; i < GridSize; i++)
            // {
            //     for (int j = 0; j < GridSize; j++)
            //     {
            //         for (int s = 0; s < 100; s++)
            //         {
            //             int x = -180 + (1000/GridSize)*i;
            //             int y = -260 + (1000/GridSize)*j;
            //             float r = (float) Math.Sqrt(x*x + y*y);
            //             float a = (float) Math.Atan2(y, x);
            //             // box[i,j].Rotate(127448, 127448+1000, a, 1);
            //             box[i,j].MoveX(127448+s*1000, 127448+(s+1)*1000, 320 + r*Math.Cos(a+.1*s), 320 + r*Math.Cos(a+.1*(s+1)));
            //             box[i,j].MoveY(127448+s*1000, 127448+(s+1)*1000, 240 + r*Math.Sin(a+.1*s), 240 + r*Math.Sin(a+.1*(s+1)));
            //         }
            //         // for (int s = 0; s < 10; s++)
            //         // {
            //         //     box[i,j].MoveX(127448+s*100, 127448+(s+1)*100, Math.Cos(s)*100, Math.Cos(s+1)*100);
            //         //     box[i,j].MoveY(127448+s*100, 127448+(s+1)*100, Math.Sin(s)*100, Math.Sin(s+1)*100);
            //         // }
            //     }
            // } 
        }
    }
}
