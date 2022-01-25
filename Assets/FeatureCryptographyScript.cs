using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FeatureCryptographyScript : MonoBehaviour {

    public KMAudio Audio;
    public KMBombModule module;
    public List<KMSelectable> buttons;
    public GameObject[] rots;
    public TextMesh[] displays;
    public TextMesh[] rotfeats;

    private readonly string[] phonlist = new string[10] { "m#n##ŋ#", "p#tʧ#k#", "b#dʤ#g#", "fθsʃ###", "vðzʒ##h", "", "##lrjw#", "ɪiʊu#ɔ", "ɛ#əɜɒ", "a#ʌ##ɑ" };
    private readonly string text = "When everyone you have ever loved is finally gone When everything you have ever wanted is finally done with When all of your nightmares are for a time obscured As by a shining brainless beacon Or a blinding eclipse of the many terrible shapes of this world When you are calm and joyful And finally entirely alone Then in a great new darkness You will finally execute your special plan " +
        "One needs to have a plan someone said who was turned away into the shadows And who I had believed was sleeping or dead Imagine he said all the flesh that is eaten The teeth tearing into it The tongue tasting its savour And the hunger for that taste Now take away that flesh he said Take away the teeth and the tongue The taste and the hunger Take away everything as it is That was my plan " +
        "My own special plan for this world I listened to these words and yet I did not wonder If this creature whom I had thought sleeping or dead would ever approach his vision Even in his deepest dreams Or his most lasting death Because I had heard of such plans such visions And I knew they did not see far enough But what was demanded in a way of a plan Needed to go beyond tongue and teeth and hunger and flesh Beyond the bones and the very dust of bones and the wind that would come to blow the dust away " +
        "And so I began to envision a darkness that was long before the dark of night And a strangely shining light That owed nothing to the light of day That day may seem like other days Once more we feel the tiny legged trepidations Once more we are mangled by a great grinding fear But that day will have no others after No more worlds like this will follow Because I have a plan A very special plan No more worlds like this No more days like that " +
        "There are but four ways to die a sardonic spirit might have said to me There is dying that occurs relatively suddenly There is dying that occurs relatively gradually There is dying that occurs relatively painlessly There is the death that is full of pain Thus by various means they are combined The sudden and the gradual The painless and the painful To yield but four ways to die And there are no others " +
        "Even after the voice stopped speaking I listened for it to speak again After hours and days and years have passed I listened for some further words Yet all I heard were the faintest echoes reminding me There are no others There are no others Was it then that I began to conceive for this world A special plan? " +
        "There are no means for escaping this world It penetrates even into your sleep And is its substance You are caught in your own dreaming Where there is no space And a hell forever where there is no time You can't do nothing you aren't told to do There is no hope for escape from this dream That was never yours The very words you speak are only its very words And you talk like a traitor Under its incessant torture " +
        "There are many who have designs upon this world And dream of wild and vast reformations I have heard them talking in their sleep Of elegant mutations And cunning annihilations I have heard them whispering in the corners of crooked houses And in the alleys and narrow back streets of this crooked creaking universe Which they with their new designs were made straight and sound But each of these new and ill conceived designs Is deranged in its heart " +
        "For they see this world as if it were alone and original And not as only one of countless others Whose nightmares all precede Like a hideous garden grown from a single seed I have heard these dreamers talking in their sleep And I stand waiting for them As at the top of a darkened flight of stairs They know nothing of me And none of the secrets of my special plan While I know every crooked creaking step of theirs " +
        "It was the voice of someone who was waiting in the shadows Who was looking at the moon and waiting for me to turn the corner And enter a narrow street And stand with him in the dull glaze of moonlight Then he said to me He whispered That my plan was misconceived That my special plan for this world was a terrible mistake Because, he said, there is nothing to do and there is nowhere to go There is nothing to be and there is no one to know Your plan is a mistake, he repeated This world is a mistake, I replied " +
        "The children always followed him When they saw him hopping by A funny walk A funny man A funny, funny, funny man He made them laugh sometimes He made them laugh oh yes he did He did he did he did he did Oh how he made them roll One day he took them to a place He knew a special place And told them things about this world This funny, funny, funny world Which made them laugh sometimes He made them laugh oh yes he did He did he did he did he did Oh how he made them roll " +
        "Then the funny man who made them laugh Sometimes he did Revealed to them his special plan His very special funny plan Knowing they would understand And maybe laugh sometimes He made them laugh Oh yes he did He did he did he did he did Their eyes grew wide beneath their lids And how he made them roll I first learned the facts from a lunatic In a dark and quiet room that smelled of stale time and space There are no people Nothing at all like that " +
        "The human phenomenon is but the sum of densely coiled layers of illusion Each of which winds itself upon the supreme insanity But there are persons of any kind When all that can be is mindless mirrors Laughing and screaming as they parade about In an endless dream But when I asked the lunatic what it was It saw itself within these mirrors As they marched endlessly in stale time and space He only looked and smiled Then he laughed and screamed And in his black and empty eyes I saw for a moment as in a mirror " +
        "A form the shade of divinity In flight from its stale infinity Of time and space and the worst of all Of this world dreams My special plan for the laughter And the screams We went to see some little show That was staged in an old shed Past the edge of town And in its beginnings all seemed well The miniature curtain stage glowed in the darkness While those dolls bounced along on their strings before our eyes And in its beginnings all seemed well " +
        "But then there came a subtle turning point which some have noticed And I was one Who quietly left the show No I did not Because I could see where things were going As the antics of those dolls grew strange And the fragile strings grew taut With their tiny pullings, tiny limbs The others around me became appalled And turned away and abandoned the show That was staged in an old shed Past the edge of town But I wanted to witness what could never be I wanted to see what could not be seen But the moment of consummate disaster When puppets turn to face the puppet master " +
        "It was twilight and I stood in a greyish haze of the vast empty building When the silence was enriched by a reverberant voice All the things of this world it said Are of but one essence For which there are no words This is the greater part which has no beginning or end And the one essence of this world for which there can be no words Is but all the things of this world This is the lesser part which had a beginning and shall have an end And for which words were conceived solely to speak of " +
        "The tiny broken beings of this world it said The beginnings and endings of this world it said For which words were conceived solely to speak of Now remove these words and what remains it asks me As I stood in the twilight of that vast empty building But I did not answer The question echoed over and over But I remained silent until the echoes died And as twilight passed into the evening I felt my Special plan for which there are no words Moving towards a greater darkness There are some who have no voices Or none that will ever speak " +
        "Because of the things they know about this world And the things they feel about this world Because the thoughts that fill a brain That is a damaged brain Because the pain that fills a body That is a damaged body Exists in other worlds Countless other worlds Each of which stands alone in an infinite empty blackness For which no words are being conceived And where no voices are able to speak When a brain is filled only with damaged thoughts When a damaged body is filled only with pain And stands alone in a world surrounded by infinite empty blackness And exists in a world for which there is no special plan " +
        "When everyone you have ever loved is finally gone When everything you have ever wanted is finally done with When all of your nightmares are for a time obscured As by a shining brainless beacon Or a blinding eclipse of the many terrible shapes of this world When you are calm and joyful And finally entirely alone Then in a great new darkness You will finally execute your special plan";

    private readonly string phontext = "wɛn ɛvrɪwʌn ju hav ɛvə lʌvd ɪz faɪnəli gɒn wɛn ɛvrɪθɪŋ ju hav ɛvə wɒntɪd ɪz faɪnəli dʌn wɪð wɛn ɔl ɒv jɔ naɪtmɜz ɑ fɔr ə taɪm əbskjʊəd az baɪ ə ʃaɪnɪŋ brɛɪnləs bikən ɔr ə blaɪndɪŋ ɪklɪps ɒv ðə mɛni tɛrəbl ʃɛɪps ɒv ðɪs wɜld wɛn ju ɑ kɑm and ʤɔɪfʊl and faɪnəli ɪntaɪəli ələʊn ðɛn ɪn ə grɛɪt nju dɑknəs ju wɪl faɪnəli ɛksɪkjut jɔ spɛʃəl plan " +
        "wʌn nidz tu hav ə plan sʌmwʌn sɛd hu wɒz tɜnd əwɛɪ ɪntu ðə ʃadəʊz and hu aɪ had bɪlivd wɒz slipɪŋ ɔ dɛd ɪmaʤɪn hi sɛd ɔl ðə flɛʃ ðat ɪz itn ðə tiθ tɜrɪŋ ɪntu ɪt ðə tʌŋ tɛəstɪŋ ɪts sɛɪvə and ðə hʌŋgə fɔ ðat tɛəst naʊ tɛɪk əwɛɪ ðat flɛʃ hi sɛd tɛɪk əwɛɪ ðə tiθ and ðə tʌŋ ðə tɛəst and ðə hʌŋgə tɛɪk əwɛɪ ɛvrɪθɪŋ az ɪt ɪz ðat wɒz maɪ plan maɪ əʊn spɛʃəl plan fɔ ðɪs wɜld " +
        "aɪ lɪsnd tu ðiz wɜdz and jɛt aɪ dɪd nɒt wʌndə ɪf ðɪs kriʧə hum aɪ had θɔt slipɪŋ ɔ dɛd wʊd ɛvər əprəʊʧ hɪz vɪʒən ivən ɪn hɪz dipəst drimz ɔ hɪz məʊst lɑstɪŋ dɛθ bɪkɒz aɪ had hɜd ɒv sʌʧ planz sʌʧ vɪʒənz and aɪ nju ðɛɪ dɪd nɒt si fɑr ɪnʌf bʌt wɒt wɒz dɪmɑndɪd ɪn ə wɛɪ ɒv ə plan nidɪd tu gəʊ bɪjɒnd tʌŋ and tiθ and hʌŋgər and flɛʃ bɪjɒnd ðə bəʊnz and ðə vɛri dʌst ɒv bəʊnz and ðə wɪnd ðat wʊd kʌm tu bləʊ ðə dʌst əwɛɪ " +
        "and səʊ aɪ bɪgan tu ɪnvɪʒən ə dɑknəs ðat wɒz lɒŋ bɪfɔ ðə dɑk ɒv naɪt and ə strɛɪnʤli ʃaɪnɪŋ laɪt ðat əʊd nʌθɪŋ tu ðə laɪt ɒv dɛɪ ðat dɛɪ mɛɪ sim laɪk ʌðə dɛɪz wʌns mɔ wi fil ðə taɪni lɛgd trɛpɪdɛɪʃənz wʌns mɔ wi ɑ maŋgld baɪ ə grɛɪt graɪndɪŋ fɪə bʌt ðat dɛɪ wɪl hav nəʊ ʌðəz ɑftə nəʊ mɔ wɜldz laɪk ðɪs wɪl fɒləʊ bɪkɒz aɪ hav ə plan ə vɛri spɛʃəl plan nəʊ mɔ wɜldz laɪk ðɪs nəʊ mɔ dɛɪz laɪk ðat " +
        "ðɜr ɑ bʌt fɔ wɛɪz tu daɪ ə sɑdɒnɪk spɪrɪt maɪt hav sɛd tu mi ðɜr ɪz daɪɪŋ ðat əkɜz rɛlətɪvli sʌdnli ðɜr ɪz daɪɪŋ ðat əkɜz rɛlətɪvli graʤuəli ðɜr ɪz daɪɪŋ ðat əkɜz rɛlətɪvli pɛɪnləsli ðɜr ɪz ðə dɛθ ðat ɪz fʊl ɒv pɛɪn ðʌs baɪ vɜrɪəs minz ðɛɪ ɑ kəmbaɪnd ðə sʌdn and ðə graʤuəl ðə pɛɪnləs and ðə pɛɪnfʊl tu jild bʌt fɔ wɛɪz tu daɪ and ðɜr ɑ nəʊ ʌðəz " +
        "ivən ɑftə ðə vɔɪs stɒpt spikɪŋ aɪ lɪsnd fɔr ɪt tu spik əgɛn ɑftər aʊəz and dɛɪz and jɪəz hav pɑst aɪ lɪsnd fɔ sʌm fɜðə wɜdz jɛt ɔl aɪ hɜd wɜ ðə fɛɪntəst ɛkəʊz rɪmaɪndɪŋ mi ðɜr ɑ nəʊ ʌðəz ðɜr ɑ nəʊ ʌðəz wɒz ɪt ðɛn ðat aɪ bɪgan tu kɒnsiv fɔ ðɪs wɜld ə spɛʃəl plan ðɜr ɑ nəʊ minz fɔr ɪskɛɪpɪŋ ðɪs wɜld ɪt pɛnɪtrɛɪts ivən ɪntu jɔ slip and ɪz ɪtz sʌbstəns ju ɑ kɔt ɪn jɔr əʊn drimɪŋ wɜ ðɜr ɪz nəʊ spɛɪs and ə hɛl fərɛvə wɜ ðɜr ɪz nəʊ taɪm ju kɑnt du nʌθɪŋ ju ɑnt təʊld tu du ðɜr ɪz nəʊ həʊp fɔr ɪskɛɪp frɒm ðɪs drim ðat wɒz nɛvə jɔz ðə vɛri wɜdz ju spik ɑr əʊnli ɪts vɛri wɜdz and ju tɔk laɪk ə trɛɪtə ʌndər ɪts ɪnsɛsnt tɔʧə " +
        "ðɜr ɑ mɛni hu hav dɪzaɪnz əpɒn ðɪs wɜld and drim ɒv waɪld and vɑst rɛfəmɛɪʃənz aɪ hav hɜd ðɛm tɔkɪŋ ɪn ðɜ slip ɒv ɛlɪgənt mjutɛɪʃənz and kʌnɪŋ ənaɪəlɛɪʃənz aɪ hav hɜd ðɛm wɪspərɪŋ ɪn ðə kɔnəz ɒv krʊkɪd haʊzɪz and ɪn ði aliz and narəʊ bak strits ɒv ðɪs krʊkɪd krikɪŋ junɪvɜs wɪʧ ðɛɪ wɪð ðɜ nju dɪzaɪnz wɜ mɛɪd strɛɪt and saʊnd bʌt iʧ ɒv ðiz nju and ɪl kɒnsivd dɪzaɪnz ɪz dɪrɛɪnʤd ɪn ɪts hɑt fɔ ðɛɪ si ðɪs wɜld az ɪf ɪt wɜr ələʊn and ərɪʤənl and nɒt az əʊnli wʌn ɒv kaʊntləs ʌðəz huz naɪtmɜz ɔl prisid laɪk ə hɪdɪəs gɑdn grəʊn frɒm ə sɪŋgl sid aɪ hav hɜd ðiz driməz tɔkɪŋ ɪn ðɜ slip and aɪ stand wɛɪtɪŋ fɔ ðɛm az at ðə tɒp ɒv ə dɑkənd flaɪt ɒv stɜz " +
        "ðɛɪ nəʊ nʌθɪŋ ɒv mi and nʌn ɒv ðə sikrɪts ɒv maɪ spɛʃəl plan waɪl aɪ nəʊ ɛvri krʊkɪd krikɪŋ stɛp ɒv ðɜz ɪt wɒz ðə vɔɪs ɒv sʌmwʌn hu wɒz wɛɪtɪŋ ɪn ðə ʃadəʊz hu wɒz lʊkɪŋ at ðə mun and wɛɪtɪŋ fɔ mi tu tɜn ðə kɔnə and ɛntər ə narəʊ strit and stand wɪð hɪm ɪn ðə dʌl glɛɪz ɒv munlaɪt ðɛn hi sɛd tu mi hi wɪspəd ðat maɪ plan wɒz mɪskənsivd ðat maɪ spɛʃəl plan fɔ ðɪs wɜld wɒz ə tɛrəbl məstɛɪk bɪkɒz hi sɛd ðɜr ɪz nʌθɪŋ tu du and ðɜr ɪz nəʊwɜ tu gəʊ ðɜr ɪz nʌθɪŋ tu bi and ðɜr ɪz nəʊ wʌn tu nəʊ jɔ plan ɪz ə məstɛɪk hi rɪpitɪd ðɪs wɜld ɪz ə məstɛɪk aɪ rɪplaɪd " +
        "ðə ʧɪldrən ɔlwɛɪz fɒləʊd hɪm wɛn ðɛɪ sɔ hɪm hɒpɪŋ baɪ ə fʌni wɔk ə fʌni man ə fʌni fʌni fʌni man hi mɛɪd ðɛm lɑf sʌmtaɪmz hi mɛɪd ðɛm lɑf əʊ jɛs hi dɪd hi dɪd hi dɪd hi dɪd hi dɪd əʊ haʊ hi mɛɪd ðɛm rəʊl wʌn dɛɪ hi tʊk ðɛm tu ə plɛɪs hi nju ə spɛʃəl plɛɪs and təʊld ðɛm θɪŋz əbaʊt ðɪs wɜld ðɪs fʌni fʌni fʌni wɜld wɪʧ mɛɪd ðɛm lɑf sʌmtaɪmz hi mɛɪd ðɛm lɑf əʊ jɛs hi dɪd hi dɪd hi dɪd hi dɪd hi dɪd əʊ haʊ hi mɛɪd ðɛm rəʊl ðɛn ðə fʌni man hu mɛɪd ðɛm lɑf sʌmtaɪmz hi dɪd rɪvild tu ðɛm hɪz spɛʃəl plan hɪz vɛri spɛʃəl fʌni plan nəʊɪŋ ðɛɪ wʊd ʌndəstand and mɛɪbi lɑf sʌmtaɪmz hi mɛɪd ðɛm lɑf əʊ jɛs hi dɪd hi dɪd hi dɪd hi dɪd hi dɪd ðɜr aɪz gru waɪd bɪniθ ðɜ lɪdz and haʊ hi mɛɪd ðɛm rəʊl " +
        "aɪ fɜst lɜnt ðə fakts frɒm ə lunətɪk ɪn ə dɑk and kwaɪət rum ðat smɛld ɒv stɛɪl taɪm and spɛɪs ðɜr ɑ nəʊ pipl nʌθɪŋ at ɔl laɪk ðat ðə hjumən fɪnɒmɪnən ɪz bʌt ðə sʌm ɒv dɛnsli kɔɪld lɛɪəz ɒv ɪluʒən iʧ ɒv wɪʧ waɪndz ɪtsɛlf əpɒn ðə sʌprim ɪnsanɪti bʌt ðɜr ɑ pɜsnz ɒv ɛni kaɪnd wɛn ɔl ðat kan bi ɪz maɪndləs mɪrəz lɑfɪŋ and skrimɪŋ az ðɛɪ pərɛɪd əbaʊt ɪn ən ɛndləs drim bʌt wɛn aɪ ɑskt ðə lunətɪk wɒt ɪt wɒz ɪt sɔ ɪtsɛlf wɪðɪn ðiz mɪrəz az ðɛɪ mɑʧt ɛndləsli ɪn stɛɪl taɪm and spɛɪs hi əʊnli lʊkt and smaɪld ðɛn hi lɑft and skrimd and ɪn hɪz blak and ɛmpti aɪz aɪ sɔ fɔr ə məʊmənt az ɪn ə mɪrə ə fɔm ðə ʃɛɪd ɒv dɪvɪnɪti ɪn flaɪt frɒm ɪts stɛɪl ɪnfɪnɪti ɒv taɪm and spɛɪs and ðə wɜst ɒv ɔl ɒv ðɪs wɜld drimz maɪ spɛʃəl plan fɔ ðə lɑftə and ðə skrimz " +
        "wi wɛnt tu si sʌm lɪtl ʃəʊ ðat wɒz stɛɪʤd ɪn ən əʊld ʃɛd pɑst ði ɛʤ ɒv taʊn and ɪn ɪts bɪgɪnɪŋz ɔl simd wɛl ðə mɪnəʧə kɜtn stɛɪʤ gləʊd ɪn ðə dɑknəs waɪl ðəʊz dɒlz baʊnst əlɒŋ ɒn ðɜ strɪŋz bɪfɔr aʊər aɪz and ɪn ɪts bɪgɪnɪŋz ɔl simd wɛl bʌt ðɛn ðɜ kɛɪm ə sʌtl tɜnɪŋ pɔɪnt wɪʧ sʌm hav nəʊtɪst and aɪ wɒz wʌn hu kwaɪətli lɛft ðə ʃəʊ nəʊ aɪ dɪd nɒt bɪkɒz aɪ kʊd si wɜ θɪŋz wɜ gəʊɪŋ az ði antɪks ɒv ðəʊz dɒlz gru strɛɪnʤ and ðə fraʤaɪl strɪŋz gru tɔt wɪð ðɜ taɪni pʊlɪŋz taɪni lɪmz ði ʌðəz əraʊnd mi bɪkɛɪm əpɔld and tɜnd əwɛɪ and əbandənd ðə ʃəʊ ðat wɒz stɛɪʤd ɪn ən əʊld ʃɛd pɑst ði ɛʤ ɒv taʊn bʌt aɪ wɒntɪd tu wɪtnəs wɒt kʊd nɛvə bi aɪ wɒntɪd tu si wɒt kʊd nɒt bi sin bʌt ðə məʊmənt ɒv kɒnsʌmət dɪzɑstə wɛn pʌpɪts tɜn tu fɛɪs ðə pʌpɪt mɑstə " +
        "ɪt wɒz twaɪlaɪt and aɪ stʊd ɪn ə grɛɪɪʃ hɛɪz ɒv ðə vɑst ɛmpti bɪldɪŋ wɛn ðə saɪləns wɒz ɪnrɪʧt baɪ ə rɪvɜbərənt vɔɪs ɔl ðə θɪŋz ɒv ðɪs wɜld ɪt sɛd ɑr ɒv bʌt wʌn ɛsns fɔ wɪʧ ðɜr ɑ nəʊ wɜdz ðɪs ɪz ðə grɛɪtə pɑt wɪʧ haz nəʊ bɪgɪnɪŋ ɔr ɛnd and ðə wʌn ɛsns ɒv ðɪs wɜld fɔ wɪʧ ðɜ kan bi nəʊ wɜdz ɪz bʌt ɔl ðə θɪŋz ɒv ðɪs wɜld ðɪs ɪz ðə lɛsə pɑt wɪʧ had ə bɪgɪnɪŋ and ʃal hav ən ɛnd and fɔ wɪʧ wɜdz wɜ kɒnsivd səʊlli tu spik ɒv ðə taɪni brəʊkən biɪŋz ɒv ðɪs wɜld ɪt sɛd ðə bɪgɪnɪŋz and ɛndɪŋz ɒv ðɪs wɜld ɪt sɛd fɔ wɪʧ wɜdz wɜ kɒnsivd səʊlli tu spik ɒv naʊ rɪmuv ðiz wɜdz and wɒt rɪmɛɪnz ɪt ɑsks mi az aɪ stʊd ɪn ðə twaɪlaɪt ɒv ðat vɑst ɛmpti bɪldɪŋ bʌt aɪ dɪd nɒt ɑnsə " +
        "ðə kwɛsʧən ɛkəʊd əʊvə and əʊvə bʌt aɪ rɪmɛɪnd saɪlənt əntɪl ðə ɛkəʊz daɪd and az twaɪlaɪt pɑst ɪntu ði ivnɪŋ aɪ fɛlt maɪ spɛʃəl plan fɔ wɪʧ ðɜr ɑ nəʊ wɜdz muvɪŋ təwɔdz ə grɛɪtə dɑknəs ðɜr ɑ sʌm hu hav nəʊ vɔɪsɪz ɔ nʌn ðat wɪl ɛvə spik bɪkɒz ɒv ðə θɪŋz ðɛɪ nəʊ əbaʊt ðɪs wɜld and ðə θɪŋz ðɛɪ fil əbaʊt ðɪs wɜld bɪkɒz ðə θɔts ðat fɪl ə brɛɪn ðat ɪz ə damɪʤd brɛɪn bɪkɒz ðə pɛɪn ðat fɪlz ə bɒdi ðat ɪz ə damɪʤd bɒdi ɪgzəsts ɪn ʌðə wɜldz kaʊntləs ʌðə wɜldz iʧ ɒv wɪʧ standz ələʊn ɪn ən ɪnfɪnɪt ɛmpti blaknəs fɔ wɪʧ nəʊ wɜdz ɑ biɪŋ kɒnsivd and wɜ nəʊ vɔɪsɪz ɑr ɛɪbl tu spik wɛn ə brɛɪn ɪz fɪld əʊnli wɪð damɪʤd θɔts wɛn ə damɪʤd bɒdi ɪz fɪld əʊnli wɪð pɛɪn and standz ələʊn ɪn ə wɜld səraʊndɪd baɪ ɪnfɪnɪt ɛmpti blaknəs and ɪgzəsts ɪn ə wɜld fɔ wɪʧ ðɜr ɪz nəʊ spɛʃəl plan " +
        "wɛn ɛvrɪwʌn ju hav ɛvə lʌvd ɪz faɪnəli gɒn wɛn ɛvrɪθɪŋ ju hav ɛvə wɒntɪd ɪz faɪnəli dʌn wɪð wɛn ɔl ɒv jɔ naɪtmɜz ɑ fɔr ə taɪm əbskjʊəd az baɪ ə ʃaɪnɪŋ brɛɪnləs bikən ɔr ə blaɪndɪŋ ɪklɪps ɒv ðə mɛni tɛrəbl ʃɛɪps ɒv ðɪs wɜld wɛn ju ɑ kɑm and ʤɔɪfʊl and faɪnəli ɪntaɪəli ələʊn ðɛn ɪn ə grɛɪt nju dɑknəs ju wɪl faɪnəli ɛksɪkjut jɔ spɛʃəl plan";

    private List<string>[] featarrange = new List<string>[3] { new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" }, new List<string> { "1", "2" }, new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" } };
    private List<string>[] rotarrange = new List<string>[3] { new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" }, new List<string> { "0", "1", "2" }, new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" } };
    private List<string>[] excerpt = new List<string>[2] { new List<string> { }, new List<string> { } };
    private List<List<int[]>> feattext = new List<List<int[]>> { };
    private string[] answer = new string[2];
    private string[] feats = new string[3];
    private int[] selected = new int[3];
    private bool[] turn = new bool[3];
    private List<int[]>[] entry = new List<int[]>[2] { new List<int[]> { }, new List<int[]> { } };

    //Word Count = 1687
    private static int moduleIDCounter;
    private int moduleID;
    private bool moduleSolved;

    private void Awake()
    {
        moduleID = ++moduleIDCounter;
        for (int i = 0; i < 3; i++)
            featarrange[i] = featarrange[i].Shuffle();
        int point = Random.Range(0, 1678);
        string[][] words = new string[2][] { text.Split(' '), phontext.Split(' ') };
        int[] phoncount = new int[2];
        while (phoncount[0] < 43)
        {
            for (int i = 0; i < 2; i++)
                excerpt[i].Add(words[i][point]);
            phoncount[0] += words[1][point].Length;
            point++;
        }
        for (int i = 0; i < excerpt[1].Count(); i++)
        {
            feattext.Add(new List<int[]> { });
            for (int j = 0; j < excerpt[1][i].Length; j++)
            {
                int[] glyph = new int[3];
                while (!phonlist[glyph[2]].Contains(excerpt[1][i][j].ToString()))
                    glyph[2]++;
                glyph[0] = phonlist[glyph[2]].IndexOf(excerpt[1][i][j].ToString());
                if (glyph[2] > 6)
                {
                    glyph[1] = (glyph[0] % 2) * 2;
                    glyph[0] /= 2;
                    glyph[0] += 7;
                    glyph[2] -= 3;
                }
                else
                {
                    glyph[1] = 1 - (glyph[2] % 2);
                    glyph[2]++;
                    glyph[2] /= 2;
                }
                feattext[i].Add(glyph);
            }
        }
        int[][] groups = Enumerable.Range(0, 3).Select(i => Enumerable.Range(0, 10).Select(z => feattext.Select(x => x.Count(y => y[i] == z)).Sum()).ToArray()).ToArray();
        int[][] once = groups.Select(x => x.Select((z, i) => z == 1 ? i : -1).Where(z => z >= 0).ToArray()).ToArray();
    redo:;
        int missing = Random.Range(1, excerpt[1].Count() - 1);
        List<int[]> m = feattext[missing];
        if (m.Count() < 3 || m.Count() > 8)
            goto redo;
        if(once.Any(x => x.Any()))
            for (int i = 0; i < m.Count(); i++)
                for (int j = 0; j < 3; j++)
                    if (once[j].Contains(m[i][j]))
                        goto redo;
        for (int i = 0; i < 2; i++)
        {
            answer[i] = excerpt[i][missing];
            excerpt[i].RemoveAt(missing);
        }
        entry[0] = m;
        feattext.RemoveAt(missing);
        int[][] zeros = groups.Select(x => x.Select((z, i) => z == 0 ? i : -1).Where(z => z >= 0).ToArray()).ToArray();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < featarrange[i].Count(); j++)
                if (j > 9 || zeros[i].Contains(j))
                    rotarrange[i].Remove(featarrange[i][j]);
            rotarrange[i] = rotarrange[i].Shuffle();
            rotfeats[i].text = rotarrange[i][0];
        }
        featarrange[1].Insert(0, "0");
        Debug.LogFormat("[Feature Cryptography #{0}] The excerpt displayed is: \"{1}\".", moduleID, excerpt[0].Join());
        Debug.LogFormat("[Feature Cryptography #{0}] The displayed phonemes are: /{1}/", moduleID, excerpt[1].Join());
        Debug.LogFormat("[Feature Cryptography #{0}] The missing word is \"{1}\".", moduleID, answer[0]);
        Debug.LogFormat("[Feature Cryptography #{0}] The missing phonemes are: /{1}/", moduleID, answer[1]);
        Debug.LogFormat("[Feature Cryptography #{0}] The features of these phonemes are: {1}.", moduleID, string.Join(", ", entry[0].Select(x => (new string[] { x[2] > 3 ? "Short" : "Voiceless", "Voiced", "Long"}[x[1]]) + (new string[] {" Labial", " Dental", " Alveolar", " Post-alveolar", " Palatal", " Velar", " Glottal", " Front", " Central", " Back" }[x[0]]) + (new string[] { " Nasal", " Plosive", " Fricative", " Approximant", " Close", " Mid", " Open"}[x[2]])).ToArray()));
        for(int i = 0; i < feattext.Count(); i++)
        {
            for (int j = 0; j < feattext[i].Count(); j++)
            {
                for (int k = 0; k < 3; k++)
                    displays[k].text += featarrange[k][feattext[i][j][k]];
                if(j < feattext[i].Count() - 1)
                    for (int k = 0; k < 3; k++)
                        displays[k].text += " ";
            }
            phoncount[1] += feattext[i].Count();
            if(i < feattext.Count() - 1)
            {
                if (phoncount[1] + feattext[i + 1].Count() < 10)
                    for (int j = 0; j < 3; j++)
                        displays[j].text += "   ";
                else
                {
                    phoncount[1] = 0;
                    for (int j = 0; j < 3; j++)
                        displays[j].text += "\n";
                }
            }
        }
        for (int i = 0; i < 3; i++)
            feats[i] = displays[i].text;
        foreach(KMSelectable button in buttons)
        {
            int b = buttons.IndexOf(button);
            button.OnInteract = delegate () 
            {
                if (!moduleSolved)
                {
                    switch (b)
                    {
                        case 6:
                            if (entry[1].Count > 0)
                            {
                                button.AddInteractionPunch(0.3f);
                                Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, button.transform);
                                entry[1].RemoveAt(entry[1].Count() - 1);
                                if (entry[1].Count() < 1)
                                    for (int i = 0; i < 3; i++)
                                        displays[i].text = feats[i];
                                else
                                    for (int i = 0; i < 3; i++)
                                        displays[i].text = entry[1].Select(x => rotarrange[i][x[i]]).Join();

                            }
                            break;
                        case 7:
                            if (entry[1].Count() < 8)
                            {
                                button.AddInteractionPunch(0.3f);
                                Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, button.transform);
                                int[] s = new int[3];
                                for (int i = 0; i < 3; i++)
                                    s[i] = selected[i];
                                entry[1].Add(s);
                                for (int i = 0; i < 3; i++)
                                    displays[i].text = entry[1].Select(x => rotarrange[i][x[i]]).Join();
                            }
                            break;
                        case 8:
                            if (entry[1].Count() > 2)
                            {
                                button.AddInteractionPunch(0.3f);
                                Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, button.transform);
                                string[][] check = new string[2][] { entry[0].Select(x => string.Join("", x.Select((y, i) => featarrange[i][y]).ToArray())).ToArray(), entry[1].Select(x => string.Join("", x.Select((y, i) => rotarrange[i][y]).ToArray())).ToArray() };
                                int[][] e = entry[1].Select(x => x.Select((y, i) => featarrange[i].IndexOf(rotarrange[i][y])).ToArray()).ToArray();
                                Debug.LogFormat("[Feature Cryptography #{0}] Submitted {1}.", moduleID, string.Join(", ", e.Select(x => (new string[] { x[2] > 3 ? "Short" : "Voiceless", "Voiced", "Long" }[x[1]]) + (new string[] { " Labial", " Dental", " Alveolar", " Post-alveolar", " Palatal", " Velar", " Glottal", " Front", " Central", " Back" }[x[0]]) + (new string[] { " Nasal", " Plosive", " Fricative", " Approximant", " Close", " Mid", " Open" }[x[2]])).ToArray()));
                                if (check[0].SequenceEqual(check[1]))
                                {
                                    moduleSolved = true;
                                    module.HandlePass();
                                    StartCoroutine(Scrolve());
                                }
                                else
                                    module.HandleStrike();
                                 
                            }
                            break;
                        default:
                            if(!turn[b / 2])
                               StartCoroutine(Turn(b / 2, b % 2));
                            break;
                    }
                }
                return false;
            };
        }
    }

    private IEnumerator Turn(int r, int d)
    {
        turn[r] = true;
        d = (2 * d) - 1;
        rotfeats[r].text = "";
        Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.BigButtonPress, buttons[r].transform);
        for(int i = 0; i < 7; i++)
        {
            rots[r].transform.Rotate(Vector3.left, 15 * d);
            yield return null;
        }
        rots[r].transform.Rotate(Vector3.right, 105 * d);
        selected[r] += rotarrange[r].Count() + d;
        selected[r] %= rotarrange[r].Count();
        rotfeats[r].text = rotarrange[r][selected[r]];
        turn[r] = false;
    }

    private IEnumerator Scrolve()
    {
        Audio.PlaySoundAtTransform("Decrypt", transform);
        for(int i = 0; i < 10; i++)
        {
            float l = 1f - (i / 9f);
            for (int j = 0; j < 3; j++)
            {
                displays[j].transform.localPosition += new Vector3(0, 0, 0.4f);
                displays[j].color = new Color32((byte)(255 * l), (byte)(221 * l), (byte)(147 * l), 255);
            }
            rotfeats[0].text = "ABCDEFGHIJKLMNOP"[Random.Range(0, 16)].ToString();
            rotfeats[1].text = Random.Range(0, 3).ToString();
            rotfeats[2].text = "ABCDEFGHIJKLMNOP"[Random.Range(0, 16)].ToString();
            yield return new WaitForSeconds(0.05f);
        }
        for (int i = 0; i < 3; i++)
            rotfeats[i].text = "";
        displays[3].text = answer[0].ToUpperInvariant();
        for(int i = 0; i < 10; i++)
        {
            displays[3].transform.localPosition += new Vector3(0, 0, 0.4f);
            displays[3].color = new Color(0, 0.1f * i, 0);
            yield return new WaitForSeconds(0.05f);
        }

    }
}
