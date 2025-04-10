//This is a cmocean colormap
//All credit to Kristen Thyng
//This colormap is under the MIT License
//All cmocean colormaps are available at https://github.com/matplotlib/cmocean/tree/master/cmocean/rgb

namespace ScottPlot.Colormaps;

public class Amp : IColormap
{
    public string Name => "Amp";
    readonly CustomPalette Colormap;
    public Color GetColor(double position) => Colormap.GetColor(position);

    public Amp()
    {
        Color[] colors =
        [
            new( 241, 237, 236 ),
            new( 241, 236, 235 ),
            new( 240, 235, 233 ),
            new( 239, 233, 232 ),
            new( 239, 232, 231 ),
            new( 238, 231, 229 ),
            new( 238, 230, 228 ),
            new( 237, 229, 227 ),
            new( 237, 227, 225 ),
            new( 236, 226, 224 ),
            new( 236, 225, 222 ),
            new( 235, 224, 221 ),
            new( 235, 223, 220 ),
            new( 234, 221, 218 ),
            new( 234, 220, 217 ),
            new( 233, 219, 215 ),
            new( 233, 218, 214 ),
            new( 233, 217, 212 ),
            new( 232, 216, 211 ),
            new( 232, 214, 210 ),
            new( 231, 213, 208 ),
            new( 231, 212, 207 ),
            new( 230, 211, 205 ),
            new( 230, 210, 204 ),
            new( 230, 209, 202 ),
            new( 229, 207, 201 ),
            new( 229, 206, 200 ),
            new( 228, 205, 198 ),
            new( 228, 204, 197 ),
            new( 228, 203, 195 ),
            new( 227, 201, 194 ),
            new( 227, 200, 192 ),
            new( 226, 199, 191 ),
            new( 226, 198, 189 ),
            new( 226, 197, 188 ),
            new( 225, 196, 187 ),
            new( 225, 195, 185 ),
            new( 225, 193, 184 ),
            new( 224, 192, 182 ),
            new( 224, 191, 181 ),
            new( 223, 190, 179 ),
            new( 223, 189, 178 ),
            new( 223, 188, 176 ),
            new( 222, 186, 175 ),
            new( 222, 185, 174 ),
            new( 222, 184, 172 ),
            new( 221, 183, 171 ),
            new( 221, 182, 169 ),
            new( 221, 181, 168 ),
            new( 220, 180, 166 ),
            new( 220, 178, 165 ),
            new( 220, 177, 163 ),
            new( 219, 176, 162 ),
            new( 219, 175, 161 ),
            new( 219, 174, 159 ),
            new( 218, 173, 158 ),
            new( 218, 172, 156 ),
            new( 217, 170, 155 ),
            new( 217, 169, 153 ),
            new( 217, 168, 152 ),
            new( 216, 167, 150 ),
            new( 216, 166, 149 ),
            new( 216, 165, 148 ),
            new( 215, 164, 146 ),
            new( 215, 162, 145 ),
            new( 215, 161, 143 ),
            new( 214, 160, 142 ),
            new( 214, 159, 140 ),
            new( 214, 158, 139 ),
            new( 213, 157, 137 ),
            new( 213, 156, 136 ),
            new( 213, 154, 135 ),
            new( 212, 153, 133 ),
            new( 212, 152, 132 ),
            new( 212, 151, 130 ),
            new( 211, 150, 129 ),
            new( 211, 149, 127 ),
            new( 211, 148, 126 ),
            new( 210, 146, 125 ),
            new( 210, 145, 123 ),
            new( 210, 144, 122 ),
            new( 209, 143, 120 ),
            new( 209, 142, 119 ),
            new( 209, 141, 118 ),
            new( 208, 140, 116 ),
            new( 208, 139, 115 ),
            new( 208, 137, 113 ),
            new( 207, 136, 112 ),
            new( 207, 135, 111 ),
            new( 207, 134, 109 ),
            new( 206, 133, 108 ),
            new( 206, 132, 106 ),
            new( 205, 131, 105 ),
            new( 205, 129, 104 ),
            new( 205, 128, 102 ),
            new( 204, 127, 101 ),
            new( 204, 126, 100 ),
            new( 204, 125, 98 ),
            new( 203, 124, 97 ),
            new( 203, 122, 96 ),
            new( 203, 121, 94 ),
            new( 202, 120, 93 ),
            new( 202, 119, 91 ),
            new( 201, 118, 90 ),
            new( 201, 117, 89 ),
            new( 201, 116, 87 ),
            new( 200, 114, 86 ),
            new( 200, 113, 85 ),
            new( 200, 112, 84 ),
            new( 199, 111, 82 ),
            new( 199, 110, 81 ),
            new( 198, 109, 80 ),
            new( 198, 107, 78 ),
            new( 198, 106, 77 ),
            new( 197, 105, 76 ),
            new( 197, 104, 74 ),
            new( 197, 103, 73 ),
            new( 196, 101, 72 ),
            new( 196, 100, 71 ),
            new( 195, 99, 70 ),
            new( 195, 98, 68 ),
            new( 195, 97, 67 ),
            new( 194, 95, 66 ),
            new( 194, 94, 65 ),
            new( 193, 93, 63 ),
            new( 193, 92, 62 ),
            new( 192, 91, 61 ),
            new( 192, 89, 60 ),
            new( 192, 88, 59 ),
            new( 191, 87, 58 ),
            new( 191, 86, 57 ),
            new( 190, 84, 56 ),
            new( 190, 83, 54 ),
            new( 189, 82, 53 ),
            new( 189, 81, 52 ),
            new( 189, 79, 51 ),
            new( 188, 78, 50 ),
            new( 188, 77, 49 ),
            new( 187, 76, 48 ),
            new( 187, 74, 48 ),
            new( 186, 73, 47 ),
            new( 186, 72, 46 ),
            new( 185, 70, 45 ),
            new( 185, 69, 44 ),
            new( 184, 68, 43 ),
            new( 184, 66, 43 ),
            new( 183, 65, 42 ),
            new( 183, 64, 41 ),
            new( 182, 63, 41 ),
            new( 181, 61, 40 ),
            new( 181, 60, 39 ),
            new( 180, 59, 39 ),
            new( 180, 57, 38 ),
            new( 179, 56, 38 ),
            new( 178, 55, 38 ),
            new( 178, 53, 37 ),
            new( 177, 52, 37 ),
            new( 176, 51, 37 ),
            new( 176, 49, 37 ),
            new( 175, 48, 36 ),
            new( 174, 47, 36 ),
            new( 174, 45, 36 ),
            new( 173, 44, 36 ),
            new( 172, 43, 36 ),
            new( 171, 42, 36 ),
            new( 170, 40, 36 ),
            new( 170, 39, 36 ),
            new( 169, 38, 36 ),
            new( 168, 37, 36 ),
            new( 167, 36, 36 ),
            new( 166, 34, 37 ),
            new( 165, 33, 37 ),
            new( 164, 32, 37 ),
            new( 163, 31, 37 ),
            new( 162, 30, 37 ),
            new( 161, 29, 37 ),
            new( 160, 28, 38 ),
            new( 159, 27, 38 ),
            new( 158, 26, 38 ),
            new( 157, 25, 38 ),
            new( 156, 24, 39 ),
            new( 155, 23, 39 ),
            new( 154, 22, 39 ),
            new( 153, 21, 39 ),
            new( 152, 21, 39 ),
            new( 151, 20, 40 ),
            new( 149, 19, 40 ),
            new( 148, 19, 40 ),
            new( 147, 18, 40 ),
            new( 146, 17, 40 ),
            new( 145, 17, 41 ),
            new( 144, 16, 41 ),
            new( 142, 16, 41 ),
            new( 141, 16, 41 ),
            new( 140, 15, 41 ),
            new( 139, 15, 41 ),
            new( 137, 15, 41 ),
            new( 136, 15, 41 ),
            new( 135, 14, 41 ),
            new( 133, 14, 41 ),
            new( 132, 14, 41 ),
            new( 131, 14, 41 ),
            new( 129, 14, 41 ),
            new( 128, 14, 41 ),
            new( 127, 14, 41 ),
            new( 125, 14, 41 ),
            new( 124, 14, 41 ),
            new( 123, 14, 41 ),
            new( 121, 14, 41 ),
            new( 120, 14, 40 ),
            new( 119, 14, 40 ),
            new( 117, 14, 40 ),
            new( 116, 14, 40 ),
            new( 115, 14, 39 ),
            new( 113, 14, 39 ),
            new( 112, 14, 39 ),
            new( 111, 14, 38 ),
            new( 109, 14, 38 ),
            new( 108, 15, 38 ),
            new( 107, 15, 37 ),
            new( 105, 15, 37 ),
            new( 104, 15, 37 ),
            new( 103, 15, 36 ),
            new( 101, 15, 36 ),
            new( 100, 14, 35 ),
            new( 99, 14, 35 ),
            new( 97, 14, 34 ),
            new( 96, 14, 34 ),
            new( 95, 14, 33 ),
            new( 93, 14, 33 ),
            new( 92, 14, 33 ),
            new( 91, 14, 32 ),
            new( 90, 14, 31 ),
            new( 88, 14, 31 ),
            new( 87, 14, 30 ),
            new( 86, 14, 30 ),
            new( 84, 13, 29 ),
            new( 83, 13, 29 ),
            new( 82, 13, 28 ),
            new( 81, 13, 28 ),
            new( 79, 13, 27 ),
            new( 78, 13, 26 ),
            new( 77, 12, 26 ),
            new( 75, 12, 25 ),
            new( 74, 12, 25 ),
            new( 73, 12, 24 ),
            new( 72, 11, 23 ),
            new( 70, 11, 23 ),
            new( 69, 11, 22 ),
            new( 68, 11, 22 ),
            new( 67, 10, 21 ),
            new( 65, 10, 20 ),
            new( 64, 10, 20 ),
            new( 63, 10, 19 ),
            new( 61, 9, 18 ),
            new( 60, 9, 18 ),
        ];

        Colormap = new CustomPalette(colors);
    }
}

