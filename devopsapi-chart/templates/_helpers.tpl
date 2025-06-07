{{/* Expand the name of the chart */}}
{{- define "devopsapi.name" -}}
{{- default .Chart.Name .Values.nameOverride | trunc 63 | trimSuffix "-" -}}
{{- end }}

{{/* Generate full name */}}
{{- define "devopsapi.fullname" -}}
{{- printf "%s-%s" .Release.Name (include "devopsapi.name" .) | trunc 63 | trimSuffix "-" -}}
{{- end }}

{{/* Generate labels */}}
{{- define "devopsapi.labels" -}}
app.kubernetes.io/name: {{ include "devopsapi.name" . }}
helm.sh/chart: {{ .Chart.Name }}-{{ .Chart.Version | replace "+" "_" }}
app.kubernetes.io/instance: {{ .Release.Name }}
app.kubernetes.io/managed-by: {{ .Release.Service }}
{{- end }}

{{/* Generate service account name */}}
{{- define "devopsapi.serviceAccountName" -}}
{{- if .Values.serviceAccount.create -}}
{{- default (include "devopsapi.fullname" .) .Values.serviceAccount.name -}}
{{- else -}}
default
{{- end -}}
{{- end }}
