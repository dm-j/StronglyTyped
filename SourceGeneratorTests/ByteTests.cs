using Newtonsoft.Json;
using StronglyTyped;
using StronglyTyped.Common;

namespace SourceGeneratorTests
{
    [StrongByte] public partial record struct TestNotWrapped;

    public partial class ByteTests
    { 
        [StrongByte] public partial record struct Test1;
        [StrongByte] public partial record struct Test2;
        [StrongByte] public partial record struct ZYX;

        [StrongByte] public partial record struct Fussy
        {
            private const byte MAX = (byte)100;

            partial void _validate(ref HashSet<string> errors)
            {
                if (Value > MAX)
                    errors.Add($"Value must be at most 100 ({Value})");
            }
        }

        [StrongByte]
        public partial record struct OverrideToString
        {
            static partial void _overrideToString(byte value, ref string result)
            {
                result = $"Overridden {value}";
            }
        }

        [StrongByte]
        public partial record struct PreprocessesToEven
        {
            static partial void _preprocess(ref byte result)
            {
                result = (byte)(result - (result % 2));
            }
        }

        [Fact]
        public Test1 As()
        {
            byte value = 1;

            return value.As<Test1>();
        }

        [Fact]
        public void AsCreatesStrongTypeWithValue()
        {
            byte value = 1;
            Test1 test = value.As<Test1>();

            Assert.Equal(value, test.Value);
        }

        [Fact]
        public void AsNullableForNullString()
        {
            byte? value = null;

            Test1? actual = value.AsNullable<Test1>();

            Assert.False(actual.HasValue);
        }

        [Fact]
        public void EqualToSelf()
        {
            var test1 = ((byte)122).As<Test1>();

            Assert.Equal(test1, test1);
        }

        [Fact]
        public void StrongTypesSameTypeWithSameValueAreEqual()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test1 two = ((byte)122).As<Test1>();

            Assert.Equal(one, two);
        }

        [Fact]
        public void EqualsOperator()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test1 two = ((byte)122).As<Test1>();

            Assert.True(one == two);
        }

        [Fact]
        public void NotEqualsOperator()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test1 two = ((byte)2).As<Test1>();

            Assert.True(one != two);
        }

        [Fact]
        public void GreaterThanOperator()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test1 two = ((byte)3).As<Test1>();

            Assert.True(one > two);
        }

        [Fact]
        public void GreaterThanEqualOperator()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test1 two = ((byte)122).As<Test1>();
            Test1 three = ((byte)2).As<Test1>();

            Assert.True(two >= three);
            Assert.True(two >= one);
        }

        [Fact]
        public void LessThanOperator()
        {
            Test1 one = ((byte)5).As<Test1>();
            Test1 two = ((byte)122).As<Test1>();

            Assert.True(one < two);
        }

        [Fact]
        public void LessThanEqualOperator()
        {
            Test1 one = ((byte)7).As<Test1>();
            Test1 two = ((byte)122).As<Test1>();
            Test1 three = ((byte)122).As<Test1>();

            Assert.True(one <= two);
            Assert.True(two <= three);
        }

        [Fact]
        public void StrongTypesSameTypeWithDifferentValueAreNotEqual()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test1 two = ((byte)3).As<Test1>();

            Assert.NotEqual(one, two);
        }

        [Fact]
        public void NotEqualToNull()
        {
            Test1 one = ((byte)122).As<Test1>();

            Assert.False(one.Equals(null));
        }

        [Fact]
        public void StrongTypesDifferentTypeWithSameValueAreNotEqual()
        {
            Test1 one = ((byte)122).As<Test1>();
            Test2 two = ((byte)122).As<Test2>();

            Assert.False(one.Equals(two));
        }

        [Fact]
        public void ToStringValue()
        {
            var value = ((byte)122);
            Test1 one = value.As<Test1>();

            Assert.Equal(value.ToString(), one.ToString());
        }

        [Fact]
        public void Serialize_SystemTextJson()
        {
            var value = (byte)100;
            Test1 expected = Test1.From(value);

            var result = System.Text.Json.JsonSerializer.Serialize(expected);

            Assert.Equal(System.Text.Json.JsonSerializer.Serialize(value), result, StringComparer.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void SerializeList_SystemTextJson()
        {
            List<Test1> list = Enumerable.Range(0, 10).Select(v => Test1.From((byte)v)).ToList();

            var result = System.Text.Json.JsonSerializer.Serialize(list);

            Assert.Equal($"[{(string.Join(",", list.Select(item => item.ToString())))}]", result, StringComparer.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void DeserializeList_SystemTextJson()
        {
            List<Test1> list = Enumerable.Range(0, 10).Select(v => Test1.From((byte)v)).ToList();

            List<Test1> result = System.Text.Json.JsonSerializer.Deserialize<List<Test1>>(System.Text.Json.JsonSerializer.Serialize(list))!;

            Assert.Equal(list, result);
        }

        [Fact]
        public void SerializesDeserializes_SystemTextJson()
        {
            var value = (byte)100;
            Test1 expected = Test1.From(value);


            var serializedGuid = System.Text.Json.JsonSerializer.Serialize(value);
            var serializedExpected = System.Text.Json.JsonSerializer.Serialize(expected);

            var deserializedExpected = System.Text.Json.JsonSerializer.Deserialize<Test1>(serializedExpected);

            Assert.Equal(serializedGuid, serializedExpected, StringComparer.InvariantCultureIgnoreCase);
            Assert.Equal(expected, deserializedExpected);
        }

        [Fact]
        public void Serialize_NewtonsoftJson()
        {
            var value = (byte)100;
            Test1 expected = Test1.From(value);

            var result = JsonConvert.SerializeObject(expected);

            Assert.Equal(JsonConvert.SerializeObject(value), result, StringComparer.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void SerializeList_NewtonsoftJson()
        {
            List<Test1> list = Enumerable.Range(0, 10).Select(v => Test1.From((byte)v)).ToList();

            var result = JsonConvert.SerializeObject(list);

            Assert.Equal($"[{(string.Join(",", list.Select(item => item.ToString())))}]", result, StringComparer.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void DeserializeList_NewtonsoftJson()
        {
            List<Test1> list = Enumerable.Range(0, 10).Select(v => Test1.From((byte)v)).ToList();

            List<Test1> result = JsonConvert.DeserializeObject<List<Test1>>(JsonConvert.SerializeObject(list))!;

            Assert.Equal(list, result);
        }

        [Fact]
        public void SerializesDeserializes_NewtonsoftJson()
        {
            var value = (byte)100;
            Test1 expected = Test1.From(value);

            var serializedGuid = JsonConvert.SerializeObject(value);
            var serializedExpected = JsonConvert.SerializeObject(expected);

            var deserializedExpected = JsonConvert.DeserializeObject<Test1>(serializedExpected);

            Assert.Equal(serializedGuid, serializedExpected, StringComparer.InvariantCultureIgnoreCase);
            Assert.Equal(expected, deserializedExpected);
        }

        [Fact]
        public void CreateValidFussy()
        {
            byte value = 1;

            Assert.True(value.TryAs(out Fussy _));
        }

        [Fact]
        public Fussy CreateInvalidFussyThroughAsDoesNotValidate()
        {
            byte value = 101;

            return value.As<Fussy>();
        }

        [Fact]
        public void CreateInvalidFussyThroughTryAsValidates()
        {
            byte value = 101;

            Assert.False(value.TryAs(out Fussy _));
        }

        [Fact]
        public void OverrideTheToString()
        {
            byte value = 101;
            Assert.Equal("Overridden 101", value.As<OverrideToString>().ToString());
        }

        [Fact]
        public void PreprocessingPreprocesses()
        {
            byte value1 = 1;
            byte value2 = 2;
            byte value3 = 3;
            byte value4 = 4;

            Assert.Equal((byte)0, value1.As<PreprocessesToEven>().Value);
            Assert.Equal((byte)2, value2.As<PreprocessesToEven>().Value);
            Assert.Equal((byte)2, value3.As<PreprocessesToEven>().Value);
            Assert.Equal((byte)4, value4.As<PreprocessesToEven>().Value);
        }

        [Fact]
        public void CreateDoesNotPreprocess()
        {
            byte value = 1;

            PreprocessesToEven pre = PreprocessesToEven.Create(value);

            Assert.Equal((byte)1, pre.Value);
        }
    }
}
