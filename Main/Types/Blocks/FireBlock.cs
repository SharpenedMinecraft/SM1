
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class FireBlock : Block
    {
        public override string BlockId => "minecraft:fire";
        public override BlockState[] PossibleStates { get; }
        public FireBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1117, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1118, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1119, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1120, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1121, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1122, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1123, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1124, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1125, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1126, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1127, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1128, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1129, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1130, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1131, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1132, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1133, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1134, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1135, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1136, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1137, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1138, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1139, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1140, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1141, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1142, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1143, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1144, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1145, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1146, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1147, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1148, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1149, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1150, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1151, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1152, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1153, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1154, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1155, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1156, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1157, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1158, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1159, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1160, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1161, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1162, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1163, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1164, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1165, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1166, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1167, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1168, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1169, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1170, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1171, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1172, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1173, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1174, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1175, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1176, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1177, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1178, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1179, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1180, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1181, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1182, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1183, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1184, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1185, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1186, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1187, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1188, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1189, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1190, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1191, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1192, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1193, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1194, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1195, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1196, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1197, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1198, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1199, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1200, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1201, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1202, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1203, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1204, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1205, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1206, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1207, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1208, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1209, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1210, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1211, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1212, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1213, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1214, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1215, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1216, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1217, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1218, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1219, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1220, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1221, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1222, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1223, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1224, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1225, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1226, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1227, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1228, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1229, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1230, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1231, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1232, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1233, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1234, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1235, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1236, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1237, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1238, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1239, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1240, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1241, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1242, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1243, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1244, new Dictionary<string, string>
                { 
            {"age", "3"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1245, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1246, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1247, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1248, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1249, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1250, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1251, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1252, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1253, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1254, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1255, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1256, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1257, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1258, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1259, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1260, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1261, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1262, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1263, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1264, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1265, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1266, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1267, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1268, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1269, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1270, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1271, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1272, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1273, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1274, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1275, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1276, new Dictionary<string, string>
                { 
            {"age", "4"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1277, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1278, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1279, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1280, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1281, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1282, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1283, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1284, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1285, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1286, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1287, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1288, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1289, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1290, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1291, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1292, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1293, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1294, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1295, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1296, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1297, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1298, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1299, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1300, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1301, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1302, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1303, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1304, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1305, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1306, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1307, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1308, new Dictionary<string, string>
                { 
            {"age", "5"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1309, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1310, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1311, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1312, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1313, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1314, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1315, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1316, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1317, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1318, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1319, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1320, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1321, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1322, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1323, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1324, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1325, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1326, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1327, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1328, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1329, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1330, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1331, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1332, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1333, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1334, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1335, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1336, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1337, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1338, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1339, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1340, new Dictionary<string, string>
                { 
            {"age", "6"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1341, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1342, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1343, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1344, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1345, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1346, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1347, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1348, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1349, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1350, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1351, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1352, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1353, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1354, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1355, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1356, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1357, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1358, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1359, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1360, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1361, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1362, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1363, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1364, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1365, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1366, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1367, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1368, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1369, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1370, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1371, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1372, new Dictionary<string, string>
                { 
            {"age", "7"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1373, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1374, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1375, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1376, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1377, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1378, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1379, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1380, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1381, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1382, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1383, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1384, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1385, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1386, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1387, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1388, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1389, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1390, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1391, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1392, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1393, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1394, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1395, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1396, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1397, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1398, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1399, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1400, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1401, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1402, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1403, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1404, new Dictionary<string, string>
                { 
            {"age", "8"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1405, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1406, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1407, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1408, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1409, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1410, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1411, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1412, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1413, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1414, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1415, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1416, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1417, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1418, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1419, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1420, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1421, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1422, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1423, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1424, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1425, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1426, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1427, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1428, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1429, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1430, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1431, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1432, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1433, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1434, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1435, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1436, new Dictionary<string, string>
                { 
            {"age", "9"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1437, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1438, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1439, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1440, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1441, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1442, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1443, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1444, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1445, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1446, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1447, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1448, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1449, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1450, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1451, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1452, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1453, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1454, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1455, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1456, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1457, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1458, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1459, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1460, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1461, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1462, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1463, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1464, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1465, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1466, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1467, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1468, new Dictionary<string, string>
                { 
            {"age", "10"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1469, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1470, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1471, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1472, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1473, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1474, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1475, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1476, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1477, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1478, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1479, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1480, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1481, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1482, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1483, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1484, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1485, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1486, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1487, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1488, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1489, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1490, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1491, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1492, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1493, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1494, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1495, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1496, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1497, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1498, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1499, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1500, new Dictionary<string, string>
                { 
            {"age", "11"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1501, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1502, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1503, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1504, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1505, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1506, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1507, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1508, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1509, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1510, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1511, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1512, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1513, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1514, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1515, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1516, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1517, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1518, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1519, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1520, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1521, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1522, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1523, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1524, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1525, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1526, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1527, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1528, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1529, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1530, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1531, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1532, new Dictionary<string, string>
                { 
            {"age", "12"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1533, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1534, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1535, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1536, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1537, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1538, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1539, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1540, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1541, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1542, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1543, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1544, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1545, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1546, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1547, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1548, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1549, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1550, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1551, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1552, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1553, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1554, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1555, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1556, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1557, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1558, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1559, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1560, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1561, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1562, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1563, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1564, new Dictionary<string, string>
                { 
            {"age", "13"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1565, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1566, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1567, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1568, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1569, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1570, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1571, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1572, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1573, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1574, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1575, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1576, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1577, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1578, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1579, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1580, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1581, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1582, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1583, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1584, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1585, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1586, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1587, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1588, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1589, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1590, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1591, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1592, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1593, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1594, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1595, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1596, new Dictionary<string, string>
                { 
            {"age", "14"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1597, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1598, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1599, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1600, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1601, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1602, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1603, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1604, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1605, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1606, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1607, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1608, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1609, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1610, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1611, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1612, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1613, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1614, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1615, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1616, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1617, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1618, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1619, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1620, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1621, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1622, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1623, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1624, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(1625, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(1626, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(1627, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(1628, new Dictionary<string, string>
                { 
            {"age", "15"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] {  };

        }
    }
}
