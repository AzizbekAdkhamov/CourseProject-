using PersonalCollection.Domain.Configuration;

namespace PersonalCollection.Application.Extansions;
public static class CollectionExtension
{
    public static IQueryable<T> ToPagedList<T>(this IQueryable<T> source, PaginationParams @params)
    {
        if(@params.pageIndex < 1)
            throw new ArgumentOutOfRangeException(nameof(@params.pageIndex),"The page index must be greater than or equal to 1");

        if (@params.pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(@params.pageSize), "The page size must be greater than or equal to 1");

        return source.Take((@params.pageSize * (@params.pageIndex - 1))..(@params.pageSize * (@params.pageIndex - 1) + @params.pageSize));
    }

    public static IEnumerable<T> ToPagedList<T>(this IEnumerable<T> source, PaginationParams @params)
    {
        if (@params.pageIndex > 1)
            throw new ArgumentOutOfRangeException(nameof(@params.pageIndex), "The page index must be greater than 1 or equal to 1");

        if (@params.pageSize < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(@params.pageSize), "The page size must be greater than or equal to 1.");
        }

        return source.Take((@params.pageSize * (@params.pageIndex - 1))..(@params.pageSize * (@params.pageIndex - 1) + @params.pageSize));
    }
}
