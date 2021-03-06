using HarmonyLib;

namespace Hudini
{
    /// <summary>
    /// Add ValheimPlus intro to compendium.
    /// </summary>
    [HarmonyPatch(typeof(Player), "OnSpawned")]
    public static class ModifyOnSpawned
    {
        private static void Prefix()
        {
            Tutorial.TutorialText introTutorial = new Tutorial.TutorialText()
            {
                m_label = "Hudini Test",
                m_name = "hudini_1",
                m_text = "Prout prout prout",
                m_topic = "Welcome to Hudini"
            };

            if (!Tutorial.instance.m_texts.Contains(introTutorial))
            {
                Tutorial.instance.m_texts.Add(introTutorial);
            }

            Player.m_localPlayer.ShowTutorial("hudini_1");
        }
    }
}
