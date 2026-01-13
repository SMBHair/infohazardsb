from PIL import Image, ImageChops
import numpy as np
import random

def glitch_frame(img, max_shift=3, slice_height=3, rgb_offset=2):
    arr = np.array(img)
    h, w, c = arr.shape

    # slice
    for y in range(0, h, slice_height):
        shift = random.randint(-max_shift, max_shift)
        arr[y:y+slice_height] = np.roll(arr[y:y+slice_height], shift, axis=1)

    # rgb
    if rgb_offset > 0:
        r_shift = random.randint(-rgb_offset, rgb_offset)
        g_shift = random.randint(-rgb_offset, rgb_offset)
        b_shift = random.randint(-rgb_offset, rgb_offset)
        arr[:,:,0] = np.roll(arr[:,:,0], r_shift, axis=1)
        arr[:,:,1] = np.roll(arr[:,:,1], g_shift, axis=0)
        arr[:,:,2] = np.roll(arr[:,:,2], b_shift, axis=1)

    return Image.fromarray(arr)

def create_glitch_gif(input_path, output_path, frames=20, duration=80):
    base_img = Image.open(input_path).convert("RGB")
    gif_frames = []

    for i in range(frames):
        frame = glitch_frame(base_img)
        gif_frames.append(frame)

    gif_frames[0].save(output_path, save_all=True, append_images=gif_frames[1:], loop=0, duration=duration)

create_glitch_gif("glitch_image/SCREEN.png", "glitch_image/SCREEN_glitch.gif")
