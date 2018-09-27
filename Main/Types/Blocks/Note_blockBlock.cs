
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Note_blockBlock : Block
    {
        public override string BlockId => "minecraft:note_block";
        public override BlockState[] PossibleStates { get; }
        public Note_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(230, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(231, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(232, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(233, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(234, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(235, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(236, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(237, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(238, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(239, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(240, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(241, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(242, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(243, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(244, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(245, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(246, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(247, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(248, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(249, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(250, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(251, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(252, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(253, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(254, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(255, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(256, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(257, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(258, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(259, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(260, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(261, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(262, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(263, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(264, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(265, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(266, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(267, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(268, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(269, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(270, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(271, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(272, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(273, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(274, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(275, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(276, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(277, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(278, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(279, new Dictionary<string, string>
                { 
            {"instrument", "harp"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(280, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(281, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(282, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(283, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(284, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(285, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(286, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(287, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(288, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(289, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(290, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(291, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(292, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(293, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(294, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(295, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(296, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(297, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(298, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(299, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(300, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(301, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(302, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(303, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(304, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(305, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(306, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(307, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(308, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(309, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(310, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(311, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(312, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(313, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(314, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(315, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(316, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(317, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(318, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(319, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(320, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(321, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(322, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(323, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(324, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(325, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(326, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(327, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(328, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(329, new Dictionary<string, string>
                { 
            {"instrument", "basedrum"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(330, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(331, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(332, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(333, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(334, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(335, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(336, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(337, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(338, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(339, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(340, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(341, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(342, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(343, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(344, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(345, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(346, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(347, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(348, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(349, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(350, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(351, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(352, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(353, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(354, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(355, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(356, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(357, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(358, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(359, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(360, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(361, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(362, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(363, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(364, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(365, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(366, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(367, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(368, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(369, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(370, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(371, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(372, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(373, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(374, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(375, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(376, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(377, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(378, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(379, new Dictionary<string, string>
                { 
            {"instrument", "snare"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(380, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(381, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(382, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(383, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(384, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(385, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(386, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(387, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(388, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(389, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(390, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(391, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(392, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(393, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(394, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(395, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(396, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(397, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(398, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(399, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(400, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(401, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(402, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(403, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(404, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(405, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(406, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(407, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(408, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(409, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(410, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(411, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(412, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(413, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(414, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(415, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(416, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(417, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(418, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(419, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(420, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(421, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(422, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(423, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(424, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(425, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(426, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(427, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(428, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(429, new Dictionary<string, string>
                { 
            {"instrument", "hat"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(430, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(431, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(432, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(433, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(434, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(435, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(436, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(437, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(438, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(439, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(440, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(441, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(442, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(443, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(444, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(445, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(446, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(447, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(448, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(449, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(450, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(451, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(452, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(453, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(454, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(455, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(456, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(457, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(458, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(459, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(460, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(461, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(462, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(463, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(464, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(465, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(466, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(467, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(468, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(469, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(470, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(471, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(472, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(473, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(474, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(475, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(476, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(477, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(478, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(479, new Dictionary<string, string>
                { 
            {"instrument", "bass"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(480, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(481, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(482, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(483, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(484, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(485, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(486, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(487, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(488, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(489, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(490, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(491, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(492, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(493, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(494, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(495, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(496, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(497, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(498, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(499, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(500, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(501, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(502, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(503, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(504, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(505, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(506, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(507, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(508, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(509, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(510, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(511, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(512, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(513, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(514, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(515, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(516, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(517, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(518, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(519, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(520, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(521, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(522, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(523, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(524, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(525, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(526, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(527, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(528, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(529, new Dictionary<string, string>
                { 
            {"instrument", "flute"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(530, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(531, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(532, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(533, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(534, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(535, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(536, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(537, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(538, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(539, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(540, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(541, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(542, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(543, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(544, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(545, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(546, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(547, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(548, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(549, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(550, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(551, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(552, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(553, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(554, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(555, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(556, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(557, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(558, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(559, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(560, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(561, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(562, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(563, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(564, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(565, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(566, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(567, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(568, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(569, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(570, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(571, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(572, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(573, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(574, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(575, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(576, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(577, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(578, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(579, new Dictionary<string, string>
                { 
            {"instrument", "bell"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(580, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(581, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(582, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(583, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(584, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(585, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(586, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(587, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(588, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(589, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(590, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(591, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(592, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(593, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(594, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(595, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(596, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(597, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(598, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(599, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(600, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(601, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(602, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(603, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(604, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(605, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(606, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(607, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(608, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(609, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(610, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(611, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(612, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(613, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(614, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(615, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(616, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(617, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(618, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(619, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(620, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(621, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(622, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(623, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(624, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(625, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(626, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(627, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(628, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(629, new Dictionary<string, string>
                { 
            {"instrument", "guitar"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(630, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(631, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(632, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(633, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(634, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(635, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(636, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(637, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(638, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(639, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(640, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(641, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(642, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(643, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(644, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(645, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(646, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(647, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(648, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(649, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(650, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(651, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(652, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(653, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(654, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(655, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(656, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(657, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(658, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(659, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(660, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(661, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(662, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(663, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(664, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(665, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(666, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(667, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(668, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(669, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(670, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(671, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(672, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(673, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(674, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(675, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(676, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(677, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(678, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(679, new Dictionary<string, string>
                { 
            {"instrument", "chime"},

            {"note", "24"},

            {"powered", "false"},
 }),

                new BlockState(680, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "0"},

            {"powered", "true"},
 }),

                new BlockState(681, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "0"},

            {"powered", "false"},
 }),

                new BlockState(682, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "1"},

            {"powered", "true"},
 }),

                new BlockState(683, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "1"},

            {"powered", "false"},
 }),

                new BlockState(684, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "2"},

            {"powered", "true"},
 }),

                new BlockState(685, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "2"},

            {"powered", "false"},
 }),

                new BlockState(686, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "3"},

            {"powered", "true"},
 }),

                new BlockState(687, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "3"},

            {"powered", "false"},
 }),

                new BlockState(688, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "4"},

            {"powered", "true"},
 }),

                new BlockState(689, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "4"},

            {"powered", "false"},
 }),

                new BlockState(690, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "5"},

            {"powered", "true"},
 }),

                new BlockState(691, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "5"},

            {"powered", "false"},
 }),

                new BlockState(692, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "6"},

            {"powered", "true"},
 }),

                new BlockState(693, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "6"},

            {"powered", "false"},
 }),

                new BlockState(694, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "7"},

            {"powered", "true"},
 }),

                new BlockState(695, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "7"},

            {"powered", "false"},
 }),

                new BlockState(696, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "8"},

            {"powered", "true"},
 }),

                new BlockState(697, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "8"},

            {"powered", "false"},
 }),

                new BlockState(698, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "9"},

            {"powered", "true"},
 }),

                new BlockState(699, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "9"},

            {"powered", "false"},
 }),

                new BlockState(700, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "10"},

            {"powered", "true"},
 }),

                new BlockState(701, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "10"},

            {"powered", "false"},
 }),

                new BlockState(702, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "11"},

            {"powered", "true"},
 }),

                new BlockState(703, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "11"},

            {"powered", "false"},
 }),

                new BlockState(704, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "12"},

            {"powered", "true"},
 }),

                new BlockState(705, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "12"},

            {"powered", "false"},
 }),

                new BlockState(706, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "13"},

            {"powered", "true"},
 }),

                new BlockState(707, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "13"},

            {"powered", "false"},
 }),

                new BlockState(708, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "14"},

            {"powered", "true"},
 }),

                new BlockState(709, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "14"},

            {"powered", "false"},
 }),

                new BlockState(710, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "15"},

            {"powered", "true"},
 }),

                new BlockState(711, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "15"},

            {"powered", "false"},
 }),

                new BlockState(712, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "16"},

            {"powered", "true"},
 }),

                new BlockState(713, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "16"},

            {"powered", "false"},
 }),

                new BlockState(714, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "17"},

            {"powered", "true"},
 }),

                new BlockState(715, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "17"},

            {"powered", "false"},
 }),

                new BlockState(716, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "18"},

            {"powered", "true"},
 }),

                new BlockState(717, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "18"},

            {"powered", "false"},
 }),

                new BlockState(718, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "19"},

            {"powered", "true"},
 }),

                new BlockState(719, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "19"},

            {"powered", "false"},
 }),

                new BlockState(720, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "20"},

            {"powered", "true"},
 }),

                new BlockState(721, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "20"},

            {"powered", "false"},
 }),

                new BlockState(722, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "21"},

            {"powered", "true"},
 }),

                new BlockState(723, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "21"},

            {"powered", "false"},
 }),

                new BlockState(724, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "22"},

            {"powered", "true"},
 }),

                new BlockState(725, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "22"},

            {"powered", "false"},
 }),

                new BlockState(726, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "23"},

            {"powered", "true"},
 }),

                new BlockState(727, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "23"},

            {"powered", "false"},
 }),

                new BlockState(728, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "24"},

            {"powered", "true"},
 }),

                new BlockState(729, new Dictionary<string, string>
                { 
            {"instrument", "xylophone"},

            {"note", "24"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Note_blockItem() };

        }
    }
}
