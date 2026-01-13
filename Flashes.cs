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
    public class Flashes : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("");
            var flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(14896, 20);
            flash.Fade(14896,18206, 0.1,0);

            flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(21517, 20);
            flash.Color(21517,0,0,0);
            flash.Fade(OsbEasing.In, 21517,24827, 0.5,0);
            flash.Fade(OsbEasing.In, 28137,31448, 0.5,0);

            Flicker(32896);

            flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(41379, 20);
            flash.ColorHsb(41379, 0, 0, 1);
            flash.StartLoopGroup(41379, 48);
            flash.Fade(0, 413.79, 0.05,0);
            flash.EndGroup();
            
            for (int i = 0; i < 24; i++)
            {
                flash.ColorHsb(48000 + 413.79*i, i*30, 1, 1);
            }
            
            // buildup
            flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(61241, 20);
            flash.Color(61241,0,0,0);
            flash.StartLoopGroup(61241, 16);
            flash.Fade(0, 413.79, 0.5, 0);
            flash.EndGroup();
            flash.StartLoopGroup(67862, 12);
            flash.Fade(0, 206.90, 0.5, 0.15);
            flash.Fade(206.90, 413.79, 0.35, 0);
            flash.EndGroup();
            flash.StartLoopGroup(72827, 3);
            flash.Fade(0, 413.79, 0.8, 0.2);
            flash.EndGroup();

            // first kiai
            BrightFlicker(77586, 0.7);
            BrightFlicker(80896, 0.3);
            BrightFlicker(84206, 0.3);
            BrightFlicker(87103, 0.7);
            BrightFlicker(90827, 0.3);
            BrightFlicker(94137, 0.3);
            BrightFlicker(100344, 0.7);

            flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(97655, 20);
            flash.ColorHsb(97655,0,0,1);
            flash.StartLoopGroup(97655, 6);
            flash.Fade(0, 413.79, 0.1, 0);
            flash.EndGroup();

            // buildup
            flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(100965, 20);
            flash.Color(100965,0,0,0);
            flash.StartLoopGroup(100965, 48);
            flash.Fade(0, 413.79, 0.5, 0);
            flash.EndGroup();
            flash.StartLoopGroup(120827, 12);
            flash.Fade(0, 206.90, 0.5, 0.15);
            flash.Fade(206.90, 413.79, 0.35, 0);
            flash.EndGroup();

            // second kiai
            BrightFlicker(133862, 0.3);
            BrightFlicker(147103, 0.3);

            // last kiai
            BrightFlicker(155379, 0.3);
            BrightFlicker(162000, 0.3);
            BrightFlicker(166551, 0.7);
            BrightFlicker(170275, 0.3);
            BrightFlicker(173586, 0.3);
            BrightFlicker(179793, 0.7);

        }

        public void Flicker(int start)
        {
            var layer = GetLayer("");
            var black = layer.CreateSprite("sb/black.png", OsbOrigin.Centre);
            black.Scale(start, 5);
            black.Fade(start, start+50, 0.5, 0.5);
            black.Fade(start+50, start+350, 0, 0);
            black.Fade(start+350, start+450, 0.75, 0.75);
            black.Fade(start+450, start+500, 0, 0);
            black.Fade(start+500, start+650, 1, 1);
            black.Fade(start+650, start+700, 0, 0);
            black.Fade(start+700, start+1000, 1, 1);
        }

        public void BrightFlicker(int start, double opacity)
        {
            var layer = GetLayer("");
            var flash = layer.CreateSprite("sb/whitev.png", OsbOrigin.Centre);
            flash.Scale(start, 20);
            flash.Fade(OsbEasing.In,start,start+51.724, opacity,0);
            flash.Fade(OsbEasing.In,start+51.724,start+51.724*2, opacity,0);
            flash.Fade(OsbEasing.In,start+51.724*2,start+51.724*3, opacity,0);
            flash.Fade(OsbEasing.In,start+51.724*3,start+51.724*4, opacity,0);
        }


    }
}
