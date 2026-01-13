using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;

namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
    {
        [Group("Timing")]
        [Configurable] public int StartTime = 0;
        [Configurable] public int EndTime = 0;
        
        [Group("Sprite")]
        [Description("Leave empty to automatically use the map's background.")]
        [Configurable] public string SpritePath = "";

        public override void Generate()
        {
            if (SpritePath == "") SpritePath = Beatmap.BackgroundPath ?? string.Empty;
            if (StartTime == EndTime) EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            var bitmap = GetMapsetBitmap(SpritePath);
            var layer = GetLayer("");
            var bg = layer.CreateSprite(SpritePath, OsbOrigin.Centre);
            bg.Scale(0, 854.0f / bitmap.Width);
            
            bg.Fade(-500, 500, 0,1);
            bg.Fade(+500, 1655, 1,1);
            bg.Fade(OsbEasing.OutQuint, 1655, 6620, 1, 0);
            bg.Fade(6620, 34758, 0, 0);

            bg.Fade(34758, 41379, 0, 0.25);
            bg.Fade(41379, 61241, 0.25, 0.25);

            bg.Fade(61241,67862,0,0.15);
            bg.Fade(67862,74482,0.15,0.15);
            bg.Fade(74482,77793,1,1);

            // first chorus
            bg.Fade(77793,96827,0.5,0.5);

            bg.ColorHsb(77793, 0, 0, 1);
            var bmw = bitmap.Width;
            DarkFlash(bg, 77793);
            BrightFlash(bg, 78620, bmw);
            DarkFlash(bg, 79448);
            BrightFlash(bg, 80275, bmw);
            DarkFlash(bg, 81103);
            BrightFlash(bg, 81931, bmw);
            DarkFlash(bg, 82758);
            BrightFlash(bg, 83586, bmw);
            DarkFlash(bg, 84413);
            BrightFlash(bg, 85241, bmw);
            DarkFlashShort(bg, 86068);
            DarkFlash(bg, 86482);
            BrightFlash(bg, 86896, bmw);

            DarkFlash(bg, 87724);
            BrightFlash(bg, 88551, bmw);
            DarkFlash(bg, 89379);
            BrightFlash(bg, 90206, bmw);
            DarkFlash(bg, 91034);
            BrightFlash(bg, 91862, bmw);
            DarkFlash(bg, 92689);
            BrightFlash(bg, 93517, bmw);
            DarkFlash(bg, 94344);
            BrightFlash(bg, 95172, bmw);
            DarkFlash(bg, 96000);
            BrightFlash(bg, 96827, bmw);
            BrightFlash(bg, 100137, bmw);

            bg.Fade(96827,100965,0,0);
            

            bg.Fade(100965,107586,0,0.15);
            bg.Fade(107586,126620,0.15,0.15);
            bg.Fade(126620,127448,0,0);

            // second chorus
            bg.Fade(127448,176275,0.5,0.5);
            bg.ColorHsb(127448, 0, 1, 1);

            bg.StartLoopGroup(127448, 8);
            DarkFlashRed(bg, 127448-127448);
            BrightFlashRed(bg, 128275-127448, bmw);
            DarkFlashRedShort(bg, 129103-127448);
            DarkFlashRedShort(bg, 129517-127448);
            BrightFlashRed(bg, 129931-127448, bmw);
            bg.EndGroup();

            // kiai 3
            bg.ColorHsb(153931, 0, 0, 1);
            DarkFlash(bg, 153931);
            BrightFlash(bg, 154758, bmw);
            DarkFlash(bg, 155586);
            BrightFlash(bg, 156413, bmw);
            DarkFlash(bg, 157241);
            BrightFlash(bg, 158068, bmw);
            DarkFlash(bg, 158896);
            BrightFlash(bg, 159724, bmw);
            DarkFlash(bg, 160551);
            BrightFlash(bg, 161379, bmw);
            DarkFlash(bg, 162206);
            BrightFlash(bg, 163034, bmw);
            DarkFlash(bg, 163862);
            BrightFlash(bg, 164689, bmw);
            DarkFlashShort(bg, 165517);
            DarkFlashShort(bg, 165931);
            BrightFlash(bg, 166344, bmw);

            DarkFlash(bg, 167172);
            BrightFlash(bg, 168000, bmw);
            DarkFlash(bg, 168827);
            BrightFlash(bg, 169655, bmw);
            DarkFlash(bg, 170482);
            BrightFlash(bg, 171310, bmw);
            DarkFlash(bg, 172137);
            BrightFlash(bg, 172965, bmw);
            DarkFlash(bg, 173793);
            BrightFlash(bg, 174620, bmw);
            DarkFlash(bg, 175448);
            BrightFlash(bg, 176275, bmw);
            BrightFlash(bg, 179586, bmw);


            // end
            bg.Fade(176275,180413,0,0);
            bg.Fade(180413,186620,0.15,0);
            
            

        }

        public void DarkFlash(OsbSprite bg, int start)
        {
            bg.ColorHsb(OsbEasing.InCubic, start, start+827, 0, 0, 0.5, 0, 0, 1);
        }

        public void DarkFlashShort(OsbSprite bg, int start)
        {
            bg.ColorHsb(OsbEasing.InCubic, start, start+827/2, 0, 0, 0.5, 0, 0, 0.75);
        }

        public void BrightFlash(OsbSprite bg, int start, float bmw)
        {
            bg.ColorHsb(start, start+827, 200, 0.5, 1, 180, 0, 1);
            bg.Scale(start, start+827, 1.03*854.0f / bmw, 854.0f / bmw);
            var layer = GetLayer("");
            var pulse = layer.CreateSprite("sb/whitecircle.png", OsbOrigin.Centre);
            pulse.ColorHsb(start, 50, 0.2, 1);
            pulse.Scale(OsbEasing.OutCubic, start, start+827, 1, 20);
            pulse.Fade(start, start+827, 0.5, 0);
        }


        public void BrightFlashRed(OsbSprite bg, int start, float bmw)
        {
            bg.ColorHsb(start, start+827, 270, 0.5, 1, 0, 1, 1);
            bg.Scale(start, start+827, 1.03*854.0f / bmw, 854.0f / bmw);
            var layer = GetLayer("");
        }
        public void DarkFlashRed(OsbSprite bg, int start)
        {
            bg.ColorHsb(OsbEasing.InCubic, start, start+827, 0, 1, 0.5, 0, 1, 1);
        }
        public void DarkFlashRedShort(OsbSprite bg, int start)
        {
            bg.ColorHsb(OsbEasing.InCubic, start, start+827/2, 0, 1, 0.5, 0, 1, 1);
        }
    }
}
