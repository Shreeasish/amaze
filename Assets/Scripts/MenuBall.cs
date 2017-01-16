﻿using UnityEngine;
using System.Collections;
using System;
using System.IO;

[RequireComponent(typeof(Light))]
public class MenuBall : MonoBehaviour
{

    float x0;
    public float minIntensity = 0f;
    public float maxIntensity = 2f;
    //Light BallLight;
    float random;
    
    double[] SinCache;
    int i;
    int cacheLength;


    void Start()
    {
        //BallLight = GetComponent<Light>();
        x0 = transform.position.x;
        i = 0;
        // SinCache Initializing
        SinCache = new double[] 
        #region
        {
     
            0.00360476970672607,
0.00987482070922852,
0.0160999298095703,
0.0226128101348877,
0.0348243713378906,
0.0366029739379883,
0.0472570657730103,
0.05345618724823,
0.0585373640060425,
0.0658191442489624,
0.0719784498214722,
           0.0793114900588989,
0.0903170108795166,
0.0922559499740601,
0.0986913442611694,
0.105099439620972,
0.116954684257507,
0.118715047836304,
0.1267249584198,
0.134749412536621,
0.140622735023499,
0.14645528793335,
            0.154543953895569,
            0.16219687461853,
            0.16973614692688,
            0.177141547203064,
0.183058738708496,0.192031145095825,0.199076890945435,0.204797029495239,0.21273148059845,0.218831062316895,0.225455164909363,
0.235339641571045, 0.244647145271301,0.250966906547546,0.256092548370361,0.266406774520874,0.273213982582092,
0.278983116149902,0.283693790435791,0.290929198265076,0.300255179405212,0.306920409202576,
0.311467885971069,0.316479086875916,0.320488333702087,0.326537847518921,0.331112623214722,0.337000131607056,
0.341363549232483,0.348733067512512,0.352786421775818,0.355695366859436,0.358505129814148,0.361240148544312,
0.363882660865784,0.366454482078552,0.371257781982422,0.371934533119202,0.374942541122437,
0.37783145904541,0.379837393760681,0.382155537605286,0.385292410850525,0.385859727859497,0.388465881347656,
0.389908194541931,0.391256332397461,0.393164038658142,0.394720792770386,0.395685791969299,
0.396554589271545,0.397325038909912,0.398126363754272,0.399052739143372,0.399188876152039,0.399631142616272,
0.399903535842896,0.399992227554321,0.399983048439026,0.399876832962036,0.399671912193298,
0.399363875389099,
0.398475170135498,
0.3983074426651,
0.39731752872467,
0.396401047706604,
0.395514607429504,
0.394529223442078,
0.392284274101257,
0.391921043395996,
0.389647006988525,
0.388187527656555,
0.386628031730652,
0.385233521461487,
0.383235692977905,
0.381398797035217,
0.379086256027222,
0.375328183174133,
0.374599933624268,
0.370823383331299,
0.368437767028809,
0.365957736968994,
0.36198616027832,
0.358002543449402,
0.355155825614929,
0.352237462997437,
0.349240064620972,
0.345513820648193,
0.339709997177124,
0.338647246360779,
0.33398449420929,
0.329439520835876,
0.325862765312195,
0.322190880775452,
0.318455457687378,
0.314623832702637,
0.306757092475891,
0.305579543113709,
0.298319101333618,
0.292057633399963,
0.285782814025879,
0.281375646591187,
0.276898384094238,
0.272359132766724,
0.267758011817932,
0.263078451156616,
0.258325934410095,
0.253378510475159,
0.243733525276184,
0.239529371261597,
0.232630252838135,
0.223451972007751,
0.22172224521637,
0.212987422943115,
0.207651853561401,
0.202285885810852,
0.196870684623718,
0.192351341247559,
0.18586802482605,
0.180333852767944,
0.174690008163452,
0.163416624069214,
0.161786198616028,
0.151660323143005,
0.140283703804016,
0.138553023338318,
0.131269931793213,
0.122578144073486,
0.116607546806335,
0.11061680316925,
0.104602098464966,
0.0985525846481323,
0.0925010442733765,
0.0863857269287109,
0.0741444826126099,
0.0665757656097412,
0.0578027963638306,
0.0494405031204224,
0.0432679653167725,
0.0370402336120605,
0.030799388885498,
0.0245518684387207,
0.0182387828826904,
0.0058215856552124,
0.00397694110870361,
-0.0055164098739624,
-0.0129090547561646,
-0.0191750526428223,
-0.0254015922546387,
-0.0378574132919312,
-0.0396637916564941,
-0.0502817630767822,
-0.0564728975296021,
-0.0626493692398071,
-0.0677876472473145,
-0.075002908706665,
-0.0811029672622681,
-0.0884588956832886,
-0.0993688106536865,
-0.101333498954773,
-0.111438155174255,
-0.117433309555054,
-0.123384714126587,
-0.132315397262573,
-0.141064167022705,
-0.146897554397583,
-0.152713060379028,
-0.158481478691101,
-0.165330052375793,
-0.175493478775024,
-0.177305102348328,
-0.184723496437073,
-0.192156553268433,
-0.197602152824402,
-0.203024506568909,
-0.208383798599243,
-0.213695406913757,
-0.224135875701904,
-0.22568941116333,
-0.234665155410767,
-0.24195921421051,
-0.249305605888367,
-0.254173755645752,
-0.258979439735413,
-0.263701558113098,
-0.268381118774414,
-0.272970199584961,
-0.277502775192261,
-0.281983971595764,
-0.286636114120483,
-0.291369259357452,
-0.296503722667694,
-0.303906559944153,
-0.305238723754883,
-0.311882197856903,
-0.315758526325226,
-0.319544732570648,
-0.323277354240417,
-0.326923608779907,
-0.332409739494324,
-0.337348580360413,
-0.340665876865387,
-0.343910217285156,
-0.347199499607086,
-0.353103876113892,
-0.353937685489655,
-0.358794450759888,
-0.361522316932678,
-0.365514397621155,
-0.369147896766663,
-0.371508598327637,
-0.373790860176086,
-0.375950932502747,
-0.378044247627258,
-0.380124151706696,
-0.383756995201111,
-0.384293258190155,
-0.386359095573425,
-0.388622522354126,
-0.390052199363709,
-0.391392648220062,
-0.392631649971008,
-0.393781781196594,
-0.394827961921692,
-0.395783066749573,
-0.396657168865204,
-0.397543489933014,
-0.398431479930878,
-0.399097323417664,
-0.399467408657074,
-0.399741768836975,
-0.399917185306549,
-0.39999532699585,
-0.399976074695587,
-0.399644076824188,
-0.399561941623688,
-0.399140775203705,
-0.398414134979248,
-0.397811651229858,
-0.397107362747192,
-0.396312594413757,
-0.395414412021637,
-0.394424319267273,
-0.393333256244659,
-0.392149925231934,
-0.389492154121399,
-0.388278365135193,
-0.386458396911621,
-0.384797215461731,
-0.383023262023926,
-0.38106095790863,
-0.377228677272797,
-0.376603305339813,
-0.372882902622223,
-0.370576441287994,
-0.366838455200195,
-0.36311799287796,
-0.360454380512238,
-0.357691884040833,
-0.35484904050827,
-0.351923644542694,
-0.3487588763237,
-0.342626929283142,
-0.341615915298462,
-0.337630152702332,
-0.332576513290405,
-0.329071760177612,
-0.325469255447388,
-0.321801245212555,
-0.318043828010559,
-0.31423282623291,
-0.310320019721985,
-0.302286624908447,
-0.297307252883911,
-0.291166961193085,
-0.285318553447723,
-0.280913472175598,
-0.276415467262268,
-0.27186107635498,
-0.267475724220276,
-0.260667085647583,
-0.255883455276489,
-0.251059055328369,
-0.246152520179749,
-0.23818838596344,
-0.231112480163574,
-0.225982904434204,
-0.220808744430542,
-0.215553283691406,
-0.210277318954468,
-0.204932689666748,
-0.194099426269531,
-0.192439436912537,
-0.185128808021545,
-0.177483081817627,
-0.171854376792908,
-0.164942264556885,
-0.154746294021606,
-0.152779579162598,
-0.143145561218262,
-0.137288212776184,
-0.131387233734131,
-0.12240731716156,
-0.113556385040283,
-0.107550382614136,
-0.101516127586365,
-0.0954718589782715,
-0.0881837606430054,
-0.0771536827087402,
-0.0752100944519043,
-0.0669218301773071,
-0.0586665868759155,
-0.052497386932373,
-0.0462825298309326,
-0.040055513381958,
-0.0338646173477173,
-0.0274559259414673,
-0.0151575803756714,
-0.0132772922515869, -0.00388216972351074, -0.00360476970672607};
        #endregion

        cacheLength = SinCache.Length;
    }


    void Update()
    {
        print(i);
        transform.position = new Vector3(x0 + (float)SinCache[i++], transform.position.y, transform.position.z);
        i = i % cacheLength;
    }
}
