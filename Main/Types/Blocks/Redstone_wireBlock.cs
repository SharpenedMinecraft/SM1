
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Redstone_wireBlock : Block
    {
        public override string BlockId => "minecraft:redstone_wire";
        public override BlockState[] PossibleStates { get; }
        public Redstone_wireBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1734, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1735, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1736, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1737, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1738, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1739, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1740, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1741, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1742, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1743, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1744, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1745, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1746, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1747, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1748, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1749, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1750, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1751, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1752, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1753, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1754, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1755, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1756, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1757, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1758, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1759, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1760, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1761, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1762, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1763, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1764, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1765, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1766, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1767, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1768, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1769, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1770, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1771, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1772, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1773, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1774, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1775, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1776, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1777, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1778, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1779, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1780, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1781, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1782, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1783, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1784, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1785, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1786, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1787, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1788, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1789, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1790, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1791, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1792, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1793, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1794, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1795, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1796, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1797, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1798, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1799, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1800, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1801, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1802, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1803, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1804, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1805, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1806, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1807, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1808, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1809, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1810, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1811, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1812, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1813, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1814, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1815, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1816, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1817, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1818, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1819, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1820, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1821, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1822, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1823, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1824, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1825, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1826, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1827, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1828, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1829, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1830, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1831, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1832, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1833, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1834, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1835, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1836, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1837, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1838, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1839, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1840, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1841, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1842, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1843, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1844, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1845, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1846, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1847, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1848, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1849, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1850, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1851, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1852, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1853, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1854, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1855, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1856, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1857, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1858, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1859, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1860, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1861, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1862, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1863, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1864, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1865, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1866, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1867, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1868, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1869, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1870, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1871, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1872, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1873, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1874, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1875, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1876, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1877, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1878, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1879, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1880, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1881, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1882, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1883, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1884, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1885, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1886, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1887, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1888, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1889, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1890, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1891, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1892, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1893, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1894, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1895, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1896, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1897, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1898, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1899, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1900, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1901, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1902, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1903, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1904, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1905, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1906, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1907, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1908, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1909, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1910, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1911, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1912, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1913, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1914, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1915, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1916, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1917, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1918, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1919, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1920, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1921, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1922, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1923, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1924, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1925, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1926, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1927, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1928, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1929, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1930, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1931, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1932, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1933, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1934, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1935, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1936, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1937, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1938, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1939, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1940, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1941, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1942, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1943, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1944, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1945, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1946, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1947, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1948, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1949, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1950, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1951, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1952, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1953, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1954, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1955, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1956, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1957, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1958, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1959, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1960, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1961, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1962, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1963, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1964, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1965, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1966, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1967, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1968, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1969, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1970, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1971, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1972, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1973, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1974, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1975, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1976, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1977, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1978, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1979, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1980, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1981, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1982, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1983, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1984, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1985, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1986, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1987, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1988, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1989, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1990, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(1991, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(1992, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(1993, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(1994, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(1995, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(1996, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(1997, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(1998, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(1999, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2000, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2001, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2002, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2003, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2004, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2005, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2006, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2007, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2008, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2009, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2010, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2011, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2012, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2013, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2014, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2015, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2016, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2017, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2018, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2019, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2020, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2021, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2022, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2023, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2024, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2025, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2026, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2027, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2028, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2029, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2030, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2031, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2032, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2033, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2034, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2035, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2036, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2037, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2038, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2039, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2040, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2041, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2042, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2043, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2044, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2045, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2046, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2047, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2048, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2049, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2050, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2051, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2052, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2053, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2054, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2055, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2056, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2057, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2058, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2059, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2060, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2061, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2062, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2063, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2064, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2065, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2066, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2067, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2068, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2069, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2070, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2071, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2072, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2073, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2074, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2075, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2076, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2077, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2078, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2079, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2080, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2081, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2082, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2083, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2084, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2085, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2086, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2087, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2088, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2089, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2090, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2091, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2092, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2093, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2094, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2095, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2096, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2097, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2098, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2099, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2100, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2101, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2102, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2103, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2104, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2105, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2106, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2107, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2108, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2109, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2110, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2111, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2112, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2113, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2114, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2115, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2116, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2117, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2118, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2119, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2120, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2121, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2122, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2123, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2124, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2125, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2126, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2127, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2128, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2129, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2130, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2131, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2132, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2133, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2134, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2135, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2136, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2137, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2138, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2139, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2140, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2141, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2142, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2143, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2144, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2145, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2146, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2147, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2148, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2149, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2150, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2151, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2152, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2153, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2154, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2155, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2156, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2157, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2158, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2159, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2160, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2161, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2162, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2163, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2164, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2165, new Dictionary<string, string>
                { 
            {"east", "up"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2166, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2167, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2168, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2169, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2170, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2171, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2172, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2173, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2174, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2175, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2176, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2177, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2178, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2179, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2180, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2181, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2182, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2183, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2184, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2185, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2186, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2187, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2188, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2189, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2190, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2191, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2192, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2193, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2194, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2195, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2196, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2197, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2198, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2199, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2200, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2201, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2202, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2203, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2204, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2205, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2206, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2207, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2208, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2209, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2210, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2211, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2212, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2213, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2214, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2215, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2216, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2217, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2218, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2219, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2220, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2221, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2222, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2223, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2224, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2225, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2226, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2227, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2228, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2229, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2230, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2231, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2232, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2233, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2234, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2235, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2236, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2237, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2238, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2239, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2240, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2241, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2242, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2243, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2244, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2245, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2246, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2247, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2248, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2249, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2250, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2251, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2252, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2253, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2254, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2255, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2256, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2257, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2258, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2259, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2260, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2261, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2262, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2263, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2264, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2265, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2266, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2267, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2268, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2269, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2270, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2271, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2272, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2273, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2274, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2275, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2276, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2277, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2278, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2279, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2280, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2281, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2282, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2283, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2284, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2285, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2286, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2287, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2288, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2289, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2290, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2291, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2292, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2293, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2294, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2295, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2296, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2297, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2298, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2299, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2300, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2301, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2302, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2303, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2304, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2305, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2306, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2307, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2308, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2309, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2310, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2311, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2312, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2313, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2314, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2315, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2316, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2317, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2318, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2319, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2320, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2321, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2322, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2323, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2324, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2325, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2326, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2327, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2328, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2329, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2330, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2331, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2332, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2333, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2334, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2335, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2336, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2337, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2338, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2339, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2340, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2341, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2342, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2343, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2344, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2345, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2346, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2347, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2348, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2349, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2350, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2351, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2352, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2353, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2354, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2355, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2356, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2357, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2358, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2359, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2360, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2361, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2362, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2363, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2364, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2365, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2366, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2367, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2368, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2369, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2370, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2371, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2372, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2373, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2374, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2375, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2376, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2377, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2378, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2379, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2380, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2381, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2382, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2383, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2384, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2385, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2386, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2387, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2388, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2389, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2390, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2391, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2392, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2393, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2394, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2395, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2396, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2397, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2398, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2399, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2400, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2401, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2402, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2403, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2404, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2405, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2406, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2407, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2408, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2409, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2410, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2411, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2412, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2413, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2414, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2415, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2416, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2417, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2418, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2419, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2420, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2421, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2422, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2423, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2424, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2425, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2426, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2427, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2428, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2429, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2430, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2431, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2432, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2433, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2434, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2435, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2436, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2437, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2438, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2439, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2440, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2441, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2442, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2443, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2444, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2445, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2446, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2447, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2448, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2449, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2450, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2451, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2452, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2453, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2454, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2455, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2456, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2457, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2458, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2459, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2460, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2461, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2462, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2463, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2464, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2465, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2466, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2467, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2468, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2469, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2470, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2471, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2472, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2473, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2474, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2475, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2476, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2477, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2478, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2479, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2480, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2481, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2482, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2483, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2484, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2485, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2486, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2487, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2488, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2489, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2490, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2491, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2492, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2493, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2494, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2495, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2496, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2497, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2498, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2499, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2500, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2501, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2502, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2503, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2504, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2505, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2506, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2507, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2508, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2509, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2510, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2511, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2512, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2513, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2514, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2515, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2516, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2517, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2518, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2519, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2520, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2521, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2522, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2523, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2524, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2525, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2526, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2527, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2528, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2529, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2530, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2531, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2532, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2533, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2534, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2535, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2536, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2537, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2538, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2539, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2540, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2541, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2542, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2543, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2544, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2545, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2546, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2547, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2548, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2549, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2550, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2551, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2552, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2553, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2554, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2555, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2556, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2557, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2558, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2559, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2560, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2561, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2562, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2563, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2564, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2565, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2566, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2567, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2568, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2569, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2570, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2571, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2572, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2573, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2574, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2575, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2576, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2577, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2578, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2579, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2580, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2581, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2582, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2583, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2584, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2585, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2586, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2587, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2588, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2589, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2590, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2591, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2592, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2593, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2594, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2595, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2596, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2597, new Dictionary<string, string>
                { 
            {"east", "side"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2598, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2599, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2600, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2601, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2602, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2603, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2604, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2605, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2606, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2607, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2608, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2609, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2610, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2611, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2612, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2613, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2614, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2615, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2616, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2617, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2618, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2619, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2620, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2621, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2622, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2623, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2624, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2625, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2626, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2627, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2628, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2629, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2630, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2631, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2632, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2633, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2634, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2635, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2636, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2637, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2638, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2639, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2640, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2641, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2642, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2643, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2644, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2645, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2646, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2647, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2648, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2649, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2650, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2651, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2652, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2653, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2654, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2655, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2656, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2657, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2658, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2659, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2660, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2661, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2662, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2663, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2664, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2665, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2666, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2667, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2668, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2669, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2670, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2671, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2672, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2673, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2674, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2675, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2676, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2677, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2678, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2679, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2680, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2681, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2682, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2683, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2684, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2685, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2686, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2687, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2688, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2689, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2690, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2691, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2692, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2693, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2694, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2695, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2696, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2697, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2698, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2699, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2700, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2701, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2702, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2703, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2704, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2705, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2706, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2707, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2708, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2709, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2710, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2711, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2712, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2713, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2714, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2715, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2716, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2717, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2718, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2719, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2720, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2721, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2722, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2723, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2724, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2725, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2726, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2727, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2728, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2729, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2730, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2731, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2732, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2733, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2734, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2735, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2736, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2737, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2738, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2739, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2740, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2741, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "up"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2742, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2743, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2744, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2745, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2746, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2747, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2748, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2749, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2750, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2751, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2752, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2753, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2754, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2755, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2756, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2757, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2758, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2759, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2760, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2761, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2762, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2763, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2764, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2765, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2766, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2767, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2768, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2769, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2770, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2771, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2772, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2773, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2774, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2775, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2776, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2777, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2778, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2779, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2780, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2781, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2782, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2783, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2784, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2785, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2786, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2787, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2788, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2789, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2790, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2791, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2792, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2793, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2794, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2795, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2796, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2797, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2798, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2799, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2800, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2801, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2802, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2803, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2804, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2805, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2806, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2807, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2808, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2809, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2810, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2811, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2812, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2813, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2814, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2815, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2816, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2817, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2818, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2819, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2820, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2821, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2822, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2823, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2824, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2825, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2826, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2827, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2828, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2829, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2830, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2831, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2832, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2833, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2834, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2835, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2836, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2837, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2838, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2839, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2840, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2841, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2842, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2843, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2844, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2845, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2846, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2847, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2848, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2849, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2850, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2851, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2852, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2853, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2854, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2855, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2856, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2857, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2858, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2859, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2860, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2861, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2862, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2863, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2864, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2865, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2866, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2867, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2868, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2869, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2870, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2871, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2872, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2873, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2874, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2875, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2876, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2877, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2878, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2879, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2880, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2881, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2882, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2883, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2884, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2885, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "side"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2886, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2887, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2888, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2889, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2890, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2891, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2892, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2893, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2894, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "0"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2895, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2896, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2897, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2898, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2899, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2900, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2901, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2902, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2903, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "1"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2904, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2905, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2906, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2907, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2908, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2909, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2910, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2911, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2912, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "2"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2913, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2914, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2915, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2916, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2917, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2918, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2919, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2920, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2921, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "3"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2922, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2923, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2924, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2925, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2926, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2927, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2928, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2929, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2930, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "4"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2931, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2932, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2933, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2934, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2935, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2936, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2937, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2938, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2939, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "5"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2940, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2941, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2942, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2943, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2944, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2945, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2946, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2947, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2948, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "6"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2949, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2950, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2951, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2952, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2953, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2954, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2955, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2956, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2957, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "7"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2958, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2959, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2960, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2961, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2962, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2963, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2964, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2965, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2966, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "8"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2967, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2968, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2969, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2970, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2971, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2972, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2973, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2974, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2975, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "9"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2976, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2977, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2978, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2979, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2980, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2981, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2982, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2983, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2984, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "10"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2985, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2986, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2987, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2988, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2989, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2990, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(2991, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(2992, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(2993, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "11"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(2994, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(2995, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(2996, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(2997, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(2998, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(2999, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(3000, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(3001, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(3002, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "12"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(3003, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(3004, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(3005, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(3006, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(3007, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(3008, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(3009, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(3010, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(3011, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "13"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(3012, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(3013, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(3014, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(3015, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(3016, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(3017, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(3018, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(3019, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(3020, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "14"},

            {"south", "none"},

            {"west", "none"},
 }),

                new BlockState(3021, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "up"},
 }),

                new BlockState(3022, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "side"},
 }),

                new BlockState(3023, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "up"},

            {"west", "none"},
 }),

                new BlockState(3024, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "up"},
 }),

                new BlockState(3025, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "side"},
 }),

                new BlockState(3026, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "side"},

            {"west", "none"},
 }),

                new BlockState(3027, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "up"},
 }),

                new BlockState(3028, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "side"},
 }),

                new BlockState(3029, new Dictionary<string, string>
                { 
            {"east", "none"},

            {"north", "none"},

            {"power", "15"},

            {"south", "none"},

            {"west", "none"},
 }),

            };
            State = PossibleStates[1160];

            Drops = new ItemStack[] {  };

        }
    }
}
