﻿using ICSharpCode.AvalonEdit.Document;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using SummaSQLGame.Databases;
using SummaSQLGame.Helpers;
using SummaSQLGame.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace SummaSQLGame.ViewModels
{
    public class WildcardViewModel : BaseExplanationViewModel
    {
        public event EventHandler<EventArgs> UpdateProgressEvent;

        #region constructor
        public WildcardViewModel()
        {
            _explanations = new List<Explanation>()
            {
                new Explanation() {
                    Image = Avatars.Default,
                    Dialog = "We blijven nog even bij de bieren tabel omdat het onderwerp wildcards verder bouwt op filteren.",
                    CanPass = true
                },
                new Explanation()
                {
                    Image = Avatars.Content,
                    Dialog = "Laten we beginnen met een beetje herhaling. Selecteer alle bieren met de soort ALE, ENGLISH",
                    CanPass = false,
                    AcceptedQueries = {"select * from bieren where soort = \"ale, english\";"}
                },
                new Explanation()
                {
                    Image = Avatars.Smiling,
                    Dialog = "Dit werkt natuurlijk goed zolang we exact opgeven welk soort bier we willen. Maar nu wil ik een overzicht van alle verschillende soorten ale. \n\n Dat kunnen we doen met het woordje LIKE en een wildcard, bijvoorbeeld: \n\n SELECT * FROM bieren WHERE soort LIKE \"ale%\";",
                    CanPass= false,
                    AcceptedQueries = {"select * from bieren where soort like \"ale%\";"}
                },
                new Explanation()
                {
                    Image = Avatars.Default,
                    Dialog = "Met LIKE zeggen we dat een kolom moet lijken op een bepaalde tekst. In dit geval ale%, waarin we aangeven dat de soort moet beginnen met het woord ale, gevolgd door 0 of meerdere karakters.",
                    CanPass = true,
                },
                new Explanation()
                {
                    Image = Avatars.Explaining,
                    Dialog = "De wildcard hoeft niet persé aan het einde te staan en je kunt er zelfs meerdere in één query gebruiken.\n\n probeer eens alle bieren te vinden met het woord TRIPLE in de naam. \n\n hint: het maakt niet uit of er tekst voor of na het woord tripel staat.",
                    CanPass = false,
                    AcceptedQueries = {"select * from bieren where naam like \"%triple%\";"}
                },
                new Explanation()
                {
                    Image = Avatars.Content,
                    Dialog = "Goed gedaan! Er zijn nog meer mogelijkheden met wildcards, maar dit is de meest voorkomende. Mocht je meer willen weten kun je dat vinden met de links rechtsonderin, maar je hebt dit onderdeel in ieder geval afgerond."
                }
            };
            CurrentExplanation = _explanations.First();
        }
        #endregion

        protected override void UpdateProgress()
        {
            EventArgs args = new EventArgs();
            UpdateProgressEvent?.Invoke(this, new EventArgs());
        }
    }
}