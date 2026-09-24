// Shared Tailwind class strings. Tailwind scans .cs files too (see @source in app.css).
public static class Ui
{
    public const string Wrap = "mx-auto max-w-[1200px] px-5 lg:px-10";

    const string Btn = "inline-flex cursor-pointer items-center justify-center gap-2 whitespace-nowrap rounded-xl font-bold transition duration-200 focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-orange motion-safe:active:scale-[0.98]";
    public const string BtnDark = Btn + " bg-dark px-6 py-3.5 text-sm text-white hover:bg-orange";
    public const string BtnDarkSm = Btn + " bg-dark px-4 py-2.5 text-[13px] text-white hover:bg-orange";
    public const string BtnDarkLg = Btn + " bg-dark px-6 py-4 text-[15px] text-white hover:bg-orange";
    public const string BtnLight = Btn + " border border-dark/20 px-6 py-3.5 text-sm text-dark hover:border-dark hover:bg-dark hover:text-white";

    public const string H1 = "text-[44px] font-extrabold leading-[1.02] tracking-[-0.03em] sm:text-[56px] lg:text-[64px]";
    public const string H2 = "text-[30px] font-extrabold leading-[1.15] tracking-[-0.02em] sm:text-[36px]";
    public const string Muted = "text-[15px] font-medium leading-[1.65] text-muted";
    public const string Img = "block size-full object-cover";
    public const string Lift = "transition duration-300 motion-safe:hover:-translate-y-1 hover:shadow-[0_20px_40px_-20px_rgba(36,24,18,0.4)]";

    public const string Label = "mb-2 block text-[13.5px] font-semibold text-dark";
    public const string FieldBase = "w-full rounded-xl border bg-field px-4 py-3.5 text-[14.5px] font-medium text-dark outline-none transition placeholder:text-[#b3987d] focus:border-dark/40 focus:bg-white focus:ring-4 focus:ring-orange/20";
    public const string Field = FieldBase + " border-transparent";
    public const string Check = "relative mt-px size-[18px] min-w-[18px] shrink-0 cursor-pointer appearance-none rounded-[5px] border border-dark/30 bg-white transition checked:border-dark checked:bg-dark after:absolute after:left-[5px] after:top-0.5 after:hidden after:h-[9px] after:w-[5px] after:rotate-45 after:border-b-2 after:border-r-2 after:border-white after:content-[''] checked:after:block focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-orange";

    public static bool IsEmail(string? s) => !string.IsNullOrWhiteSpace(s) && System.Net.Mail.MailAddress.TryCreate(s.Trim(), out var a) && a.Address == s.Trim() && s.Contains('.');
}
