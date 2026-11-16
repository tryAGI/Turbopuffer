namespace Turbopuffer.IntegrationTests;

/// <summary>
/// What generate.sh does to the spec, checked without an API key.
///
/// generate.sh renames a Stainless `?` path and a `string` reserved keyword with yq; both break
/// generation if left alone.
///
/// This SDK passes no `--security-scheme`, so there is no credential to assert; what can be checked
/// is that the fix still produces the surface it exists to produce. Every other test here needs an
/// API key and reports inconclusive without one, so the suite printed `Skipped!` and exited 0 —
/// which reads exactly like a passing run.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheSurfaceTheSpecFixProducesIsStillThere()
    {
        var method = typeof(global::Turbopuffer.ITurbopufferClient)
            .GetMethods()
            .FirstOrDefault(x => x.Name == "CreateNamespacesByNamespaceAsync");

        Assert.IsNotNull(
            method,
            "Turbopuffer.ITurbopufferClient.CreateNamespacesByNamespaceAsync is gone. It is generated from the document " +
            "generate.sh produces; if a spec refresh removed it, look at the fix rather than at " +
            "this test.");
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://{region}.turbopuffer.com", global::Turbopuffer.TurbopufferClient.DefaultBaseUrl);
    }
}
