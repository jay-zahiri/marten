using System;
using JasperFx.CodeGeneration.Frames;
using Vogen;

namespace ValueTypeTests;

[ValueObject<Guid>]
public partial struct GuidId;

[ValueObject<int>]
public partial struct IntId;

[ValueObject<long>]
public partial struct LongId;

[ValueObject<string>]
public partial struct StringId;

[ValueObject<DateOnly>]
public partial struct DateId;

public record NewGuidId(Guid Value);
public record NewIntId(int Value);
public record NewStringId(string Value);
public record NewLongId(long Value);

public record NewDateId(DateOnly Value);


