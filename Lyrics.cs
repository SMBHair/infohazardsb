using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;

namespace StorybrewScripts
{
    public class Lyrics : StoryboardObjectGenerator
    {        
        public override void Generate()
        {
            var layer = GetLayer("");

            var inmydream = layer.CreateSprite("sb/inmydream.png", OsbOrigin.Centre);
            var isawhim = layer.CreateSprite("sb/isawhim.png", OsbOrigin.Centre);
            var themanwithout = layer.CreateSprite("sb/themanwithout.png", OsbOrigin.Centre);
            var ahead = layer.CreateSprite("sb/ahead.png", OsbOrigin.Centre);
            var onmyscreen = layer.CreateSprite("sb/onmyscreen.png", OsbOrigin.Centre);
            var wheniwas = layer.CreateSprite("sb/wheniwas.png", OsbOrigin.Centre);
            var fourandten = layer.CreateSprite("sb/fourandten.png", OsbOrigin.Centre);
            var ididntmean = layer.CreateSprite("sb/ididntmean.png", OsbOrigin.Centre);
            var toseehim = layer.CreateSprite("sb/toseehim.png", OsbOrigin.Centre);
            var itallhappened = layer.CreateSprite("sb/itallhappened.png", OsbOrigin.Centre);
            var sofast = layer.CreateSprite("sb/sofast.png", OsbOrigin.Centre);
            var whatdoesitmean = layer.CreateSprite("sb/whatdoesitmean.png", OsbOrigin.Centre);
            var nowallthistime = layer.CreateSprite("sb/nowallthistime.png", OsbOrigin.Centre);
            var haspassed = layer.CreateSprite("sb/haspassed.png", OsbOrigin.Centre);
            var IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            var MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            var DREAM = layer.CreateSprite("sb/DREAM.png", OsbOrigin.Centre);
            var ON = layer.CreateSprite("sb/ON.png", OsbOrigin.Centre);
            var SCREEN = layer.CreateSprite("sb/SCREEN.png", OsbOrigin.Centre);
            var DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            var SCREEN_glitch = layer.CreateAnimation("sb/SCREEN_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre); 

            
            inmydream.Fade(7862, 7862+300, 0, 1);
            inmydream.Fade(7862+300, 9517, 1, 1);
            isawhim.Fade(9517, 11379, 1, 1);
            themanwithout.Fade(11379, 12827, 1, 1);
            ahead.Fade(12827, 14482, 1, 1);
            onmyscreen.Fade(14482, 16137, 1, 1);
            isawhim = layer.CreateSprite("sb/isawhim.png", OsbOrigin.Centre);
            isawhim.Fade(16137,18000,1,1);
            wheniwas.Fade(18000, 19034,1,1);
            fourandten.Fade(19034, 20896,1,1);
            ididntmean.Fade(20896,22758,1,1);
            toseehim = layer.CreateSprite("sb/toseehim.png", OsbOrigin.Centre);
            toseehim.Fade(22758,24620,1,1);
            itallhappened.Fade(24620, 26068,1,1);
            sofast.Fade(26068,27517,1,1);
            whatdoesitmean.Fade(27517,29379,1,1);
            toseehim = layer.CreateSprite("sb/toseehim.png", OsbOrigin.Centre);
            toseehim.Fade(29379,31241,1,1);
            nowallthistime.Fade(31241,32689,1,1);
            haspassed.Fade(32689,33103,1,1);
            haspassed.Fade(OsbEasing.OutCubic, 33103,33931,1,0);


            IN.Fade(34344,34551,1,1);
            MY.Fade(34551,34758,1,1);
            DREAM_glitch.Fade(34758,40965,1,1);
            ON.Fade(40965,41172,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(41172,41379,1,1);
            SCREEN_glitch.Fade(41379,47586,1,1);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(47586,47793,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(47793,48000,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(48000,54206,1,1);

            ON = layer.CreateSprite("sb/ON.png", OsbOrigin.Centre);
            ON.Fade(54206,54413,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(54413,54620,1,1);
            SCREEN_glitch = layer.CreateAnimation("sb/SCREEN_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            SCREEN_glitch.Fade(54620,60827,1,1);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(60827,61034,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(61034,61241,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(61241,67448,1,0.3);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(67448,67655,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(67655,67862,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(67862,74068,1,0.3);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(74068,74275,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(74275,74482,1,1);



            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(100551,100758,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(100758,100965,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(100965,107172,1,0.3);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(107172,107379,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(107379,107586,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(107586,113793,1,0.3);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(113793,114000,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(114000,114206,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(114206,125793,1,1);



            inmydream = layer.CreateSprite("sb/inmydream.png", OsbOrigin.Centre);
            inmydream.Fade(153517,153517+300,0,1);
            inmydream.Fade(153517+300,155172,1,1);
            isawhim = layer.CreateSprite("sb/isawhim.png", OsbOrigin.Centre);
            isawhim.Fade(155172,157034,1,1);
            themanwithout = layer.CreateSprite("sb/themanwithout.png", OsbOrigin.Centre);
            themanwithout.Fade(157034,158482,1,1);
            ahead = layer.CreateSprite("sb/ahead.png", OsbOrigin.Centre);
            ahead.Fade(158482,160137,1,1);
            onmyscreen = layer.CreateSprite("sb/onmyscreen.png", OsbOrigin.Centre);
            onmyscreen.Fade(160137,161793,1,1);
            isawhim = layer.CreateSprite("sb/isawhim.png", OsbOrigin.Centre);
            isawhim.Fade(161793,163655,1,1);
            wheniwas = layer.CreateSprite("sb/wheniwas.png", OsbOrigin.Centre);
            wheniwas.Fade(163655,164689,1,1);
            fourandten = layer.CreateSprite("sb/fourandten.png", OsbOrigin.Centre);
            fourandten.Fade(164689,166551,1,1);
            ididntmean = layer.CreateSprite("sb/ididntmean.png", OsbOrigin.Centre);
            ididntmean.Fade(166551,168413,1,1);
            toseehim = layer.CreateSprite("sb/toseehim.png", OsbOrigin.Centre);
            toseehim.Fade(168413,170275,1,1);
            itallhappened = layer.CreateSprite("sb/itallhappened.png", OsbOrigin.Centre);
            itallhappened.Fade(170275,171724,1,1);
            sofast = layer.CreateSprite("sb/sofast.png", OsbOrigin.Centre);
            sofast.Fade(171724,173172,1,1);
            whatdoesitmean = layer.CreateSprite("sb/whatdoesitmean.png", OsbOrigin.Centre);
            whatdoesitmean.Fade(173172,175034,1,1);
            toseehim = layer.CreateSprite("sb/toseehim.png", OsbOrigin.Centre);
            toseehim.Fade(175034,176275,1,1);
            nowallthistime = layer.CreateSprite("sb/nowallthistime.png", OsbOrigin.Centre);
            nowallthistime.Fade(176896,178344,1,1);
            haspassed = layer.CreateSprite("sb/haspassed.png", OsbOrigin.Centre);
            haspassed.Fade(178344,179586,1,1);

            IN = layer.CreateSprite("sb/IN.png", OsbOrigin.Centre);
            IN.Fade(180000,180206,1,1);
            MY = layer.CreateSprite("sb/MY.png", OsbOrigin.Centre);
            MY.Fade(180206,180413,1,1);
            DREAM_glitch = layer.CreateAnimation("sb/DREAM_glitch/frame_000.png", 10, 103.4, OsbLoopType.LoopForever, OsbOrigin.Centre);
            DREAM_glitch.Fade(180413,186206,1,0);
        }
    }
}
